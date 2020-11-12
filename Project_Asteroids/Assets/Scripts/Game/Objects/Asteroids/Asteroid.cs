using Assets.Scripts.Game.Objects.Asteroids;
using Game.Main;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.Objects.Asteroids
{
    public class Asteroid : MonoBehaviour, IShootable
    {
        public event System.Action OnExplode;
        int IShootable.Score => 150/_health;

        private int _health;
        private Vector2 _direction;
        private float _rotation;

        private float _timeToDestroy;



        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private Renderer _renderer;

        public void RandomSetup(Vector2 direction)
        {
            RandomSetup(direction, Random.Range(1, 4));
        }

        public void RandomSetup(Vector2 direction, int health)
        {
            Setup(direction, Random.Range(1f, 10f), Random.Range(-100f, 100f), health);
        }

        private void RandomSetup(int health)
        {
            RandomSetup(new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)), health);
        }

        private void Setup(Vector2 direction, float speed, float rotation, int health)
        {
            _direction = direction.normalized * speed;
            _rotation = rotation;
            _health = health;
            SetLook();

            _timeToDestroy = 10f;
            UpdateManager.Instance.OnFixUpdate += MyFixUpdate;
        }


        private void RandomDirection()
        {
            _direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
            _direction *= Random.Range(1, 10f);
            _rotation = Random.Range(-10f, 10f);
        }


        private void MyFixUpdate()
        {
            _rb.MovePosition(_rb.position + _direction * Time.fixedDeltaTime);
            _rb.MoveRotation(_rb.rotation + _rotation * Time.fixedDeltaTime);


            if(_timeToDestroy > 0)
            {
                _timeToDestroy -= Time.fixedDeltaTime;
                return;
            }

            if (!_renderer.isVisible)
                Explode();
        }


        private void SetLook()
        {
            switch (_health)
            {
                case 3:
                    {
                        transform.localScale = new Vector3(1f, 1f, 1f);
                        break;
                    }
                case 2:
                    {
                        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                        break;
                    }
                case 1:
                    {
                        transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
                        break;
                    }
            }


        }

        private void Split()
        {
            _health -= 1;

            if (_health <= 0)
            {
                Explode();
                return;
            }

            var splitAsteroidObj = GameObject.Instantiate(this, transform.position, transform.rotation);
            var splitAsteroid = splitAsteroidObj.GetComponent<Asteroid>();
            splitAsteroid.RandomSetup(_health);

            RandomDirection();
            SetLook();
        }


        private void Explode()
        {
            OnExplode?.Invoke();
            Destroy(gameObject);
        }

        void IShootable.Hit()
        {
            Split();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            switch(collision.gameObject.tag)
            {
                case "Ship":
                case "UFO":
                    {
                        collision.gameObject.GetComponent<IShootable>().Hit();
                        break;
                    }
            }

            Debug.Log("Астероид столкнулся с " + collision.gameObject.tag);
        }


        private void OnDestroy()
        {
            UpdateManager.Instance.OnFixUpdate -= MyFixUpdate;
        }
    }
}
