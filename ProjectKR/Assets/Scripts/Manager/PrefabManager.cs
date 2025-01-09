using UnityEngine;

public class PrefabManager
{
    public T Load<T>(string path) where T: Object
    {
        return Resources.Load<T>(path);
    }
    public GameObject Instantiate(string path, Transform parent = null)
    {
        GameObject go = Load<GameObject>($"Prefab/{path}");
        if (go == null) return null;
        return Object.Instantiate(go, parent);
    }
    public void Destroy(GameObject go)
    {
        if(go == null) return;
        Object.Destroy(go);
    }
}
