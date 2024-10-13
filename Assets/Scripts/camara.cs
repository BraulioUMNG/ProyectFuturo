using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform CR;   

    // Update is called once per frame
    void Update()
    {
        Vector3 position= transform.position;
        position.x = CR.transform.position.x;
        transform.position = position;
        position.y = CR.transform.position.y;
        transform.position = position;
    }
}
