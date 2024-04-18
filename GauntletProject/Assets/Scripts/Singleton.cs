using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<E> : MonoBehaviour where E : Component
{
    private static E _instance;

    public static E Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<E>();

                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(E).Name;
                    _instance = obj.AddComponent<E>();
                }
            }
            return _instance;
        }
    }
    public virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as E;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

}
