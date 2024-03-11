using System;
using UnityEngine;

namespace com.simbask.sodata.Runtime
{
    [CreateAssetMenu(fileName = "GameObjectVar", menuName = "SO Data/Create new variable/GameObjectReference")]
    public class GameObjectVariable : ScriptableObject
    {
        [SerializeField] private GameObject _gameObject;

        public event Action<GameObject> OnValueChanged;

        public GameObject Value
        {
            get { return _gameObject; }
            set
            {
                if (_gameObject != value)
                {
                    _gameObject = value;
                    OnValueChanged?.Invoke(_gameObject);
                }
            }
        }
    }
}