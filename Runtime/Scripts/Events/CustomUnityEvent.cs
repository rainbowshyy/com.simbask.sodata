using System;
using UnityEngine;
using UnityEngine.Events;

namespace com.simbask.sodata.Runtime
{
    [Serializable]
    public class CustomUnityEvent : UnityEvent<Component, object> {}
}
