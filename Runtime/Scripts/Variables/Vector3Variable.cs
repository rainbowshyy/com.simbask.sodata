using System;
using UnityEngine;

namespace com.simbask.sodata.Runtime
{
    [CreateAssetMenu(fileName = "Vector3Var", menuName = "SO Data/Create new variable/Vector 3")]
    public class Vector3Variable : ScriptableObject
    {
        [SerializeField] private Vector3 _vector;

        public event Action<Vector3> OnValueChanged;

        public Vector3 Value
        {
            get { return _vector; }
            set
            {
                if (_vector != value)
                {
                    _vector = value;
                    OnValueChanged?.Invoke(_vector);
                }
            }
        }
    }
}