using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    public class CommonBee : MonoBehaviour
    {

        private NavMeshAgent _agent;

        private int _hitPoint = 3;
        
        private bool _inCriticalStage = false;
        // Start is called before the first frame update
        void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
        
        }

        public void HitBee()
        {
            if (IsCritical())
            {
                OneHitBee();
            }
            else
            {
                _hitPoint--;
            }
            Debug.Log(_hitPoint);
        }

        public void OneHitBee()
        {
            _hitPoint = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if (_hitPoint == 0)
            {
                DestroyBee();
            }
        }
        
        public void EnableCriticalStage()
        {
            _inCriticalStage = true;
            Debug.Log("currently critical");
        }
        public void DisableCriticalStage()
        {
            _inCriticalStage = false;
            Debug.Log("currently NOT critical");
        }
        
        public bool IsCritical()
        {
            return _inCriticalStage;
        }

        private void DestroyBee()
        {
            gameObject.SetActive(false);
        }
    }
}
