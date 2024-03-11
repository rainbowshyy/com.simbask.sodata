using System;
using UnityEngine;

namespace com.simbask.sodata.Runtime
{
    [CreateAssetMenu(fileName = "StringVar", menuName = "SO Data/Create new variable/String")]
    public class StringVariable : ScriptableObject
    {
        [SerializeField] private string _string;

        public event Action<string> OnValueChanged;

        public string Value 
        { 
            get { return _string; } 
            set
            {
                if (_string != value)
                {
                    _string = value;
                    OnValueChanged?.Invoke(_string);
                }
            }
        }
    }
}
