using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour 
{
    [SerializeField]
    private Transform _creationPoint = null;
    [SerializeField]
    private GameObject _heartPickUp = null;
    [SerializeField]
    private GameObject _bombPickUp = null;

    private GameObject newObjInstance;

    private float randomValue;

    [SerializeField]
    private float objLifeTime = 5f;


    private void Start()
    {
        InvokeRepeating("Create", 1f, Random.Range(1f, 3f));
    }


    public void Create()
    {
        randomValue = Random.Range(1f, 10f);
        // Heart or Bomb
        if (randomValue > 4)
        {
            newObjInstance = Instantiate(_heartPickUp, _creationPoint.position, _creationPoint.rotation);
        }
        else
        {
            newObjInstance = Instantiate(_bombPickUp, _creationPoint.position, _creationPoint.rotation);
        }

        DestroyObj();
    }

    public void DestroyObj()
    {
        Destroy(newObjInstance, objLifeTime);
    }
}
