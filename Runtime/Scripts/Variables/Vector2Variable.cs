using System;
using UnityEngine;

namespace com.simbask.sodata.Runtime
{
    [CreateAssetMenu(fileName = "Vector2Var", menuName = "SO Data/Create new variable/Vector 2")]
    public class Vector2Variable : ScriptableObject
    {
        [SerializeField] private Vector2 _vector;

        public event Action<Vector2> OnValueChanged;

        public Vector2 Value
        {
            get { return _vector; }
            set
            {
                if (_vector != value)
                {
                    _vector = value;
                    OnValueChanged?.Invoke(value);
                }
            }
        }
    }
}