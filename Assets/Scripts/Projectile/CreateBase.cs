using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class CreateBase : MonoBehaviour
{
    [SerializeField] private GameObject prefObject;
    [SerializeField] private int timeLife = 3;
    [SerializeField] private int deltaLife = 90;

    private List<GameObject> allObject;
    private List<bool> activObject;
    private List<int> timeObject;

    public void Start()
    {
        allObject = new List<GameObject>();
        activObject = new List<bool>();
        timeObject = new List<int>();
    }
    public void Update()
    {
        ControlObject();
    }

    public virtual void ControlObject()
    {
        if(allObject != null && Time.frameCount % deltaLife == 0)
        {
            for (int i = 0; i < allObject.Count; i++)
            {
                if (timeObject[i] > 0) { timeObject[i]--; }
                else { Active(i, false); }
            }
        }
    }

    private void Active(int index, bool active)
    {
        allObject[index].SetActive(active);
        activObject[index] = active;
        if (active) 
        { 
            timeObject[index] = timeLife;
        }
        else
        {
            Reload(index);
        }
    }

    private int Active() => activObject.IndexOf(false);

    protected List<GameObject> getObjects { get => allObject; } 
  

    public abstract void Reload(int index);

    public GameObject AddObject()
    {
        var index = Active();
        if (index == -1)
        {
            
            var newObject = Instantiate(prefObject);
            activObject.Add(true);
            timeObject.Add(timeLife);
            allObject.Add(newObject);
            newObject.AddComponent<CreatObject>().createObject=gameObject;
            return newObject;
        }
        else
        {
            Active(index, true);
            return allObject[index];
        }
    }

    public void DesroyObject(GameObject gameObject)
    {
        int index = 0;
        for(int i = 0; i <= allObject.Count; i++)
        {
            if(i == allObject.Count) { Debug.Log("GameObject not find"); return; }
            if(gameObject == allObject[i]) { index = i; break; }
        }
        allObject.RemoveAt(index);
        activObject.RemoveAt(index);
        timeObject.RemoveAt(index);
    }
}
