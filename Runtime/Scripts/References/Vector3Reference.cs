using System;
using UnityEngine;

namespace com.simbask.sodata.Runtime
{
    [Serializable]
    public class Vector3Reference
    {
        public bool UseConstant = true;
        public Vector3 ConstantValue;
        public Vector3Variable Variable;

        public Vector3 Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public void RegisterListener(Action<Vector3> onValueChanged)
        {
            Variable.OnValueChanged += onValueChanged;
        }

        public void UnregisterListener(Action<Vector3> onValueChanged)
        {
            Variable.OnValueChanged -= onValueChanged;
        }
    }
}