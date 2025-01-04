using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIBase : MonoBehaviour
{
    protected Dictionary<Type, UnityEngine.Object[]> _objects = new();

    protected void Bind<T>(Type type) where T : UnityEngine.Object
    {
        string[] names = Enum.GetNames(type);
        UnityEngine.Object[] objects = new UnityEngine.Object[names.Length];
        _objects.Add(typeof(T), objects);

        for (int i = 0; i < names.Length; i++)
        {
            if (typeof(T)== typeof(GameObject))
                objects[i] = UtilFunc.FindChild(gameObject, names[i], true);
            else
                objects[i] = UtilFunc.FindChild<T>(gameObject, names[i], true);
            if (objects[i] == null)
                Debug.Log($"Failed UI Bind {names[i]}");
        }
    }
    protected T Get<T>(int index) where T : UnityEngine.Object
    {
        UnityEngine.Object[] objects = null;
        if( _objects.TryGetValue(typeof(T), out objects) == false)
        {
            return null;
        }
        return objects[index] as T;
    }
    protected static void AddEvent(GameObject go, Action<PointerEventData> action, UIEvent type = UIEvent.CLICK)
    {
        UIEventHandler evt = UtilFunc.GetorAddComponent<UIEventHandler>(go);
        switch (type) 
        {
            case UIEvent.DOWN:
                evt.OnDownHandler -= action;
                evt.OnDownHandler += action;
                break;
            case UIEvent.UP:
                evt.OnUpHandler -= action;
                evt.OnUpHandler += action;
                break;
            case UIEvent.CLICK:
                evt.OnClickHandler -= action;
                evt.OnClickHandler += action;
                break;
        }
    }
}
