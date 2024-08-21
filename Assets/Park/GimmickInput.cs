
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GimmickInput : MonoBehaviour
{
    public List<GimmickTrigger> Trigger;
    [Serializable]
    public class SimpleEvent : UnityEvent { }

    // 인스펙터에서 호출할 수 있는 이벤트
    public SimpleEvent OutputEvent;

    public void InvokeEvent()
    {
        // 이벤트가 설정된 경우에만 호출
        if (OutputEvent != null)
        {
            // 이벤트를 호출
            OutputEvent.Invoke();
        }
    }
}