using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculinVirus : MonoBehaviour
{
    public GameObject virus;
    public float waktuMinimal,waktuMaximal;
    public float posisiMinimal, posisimaximal;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MunculVirus());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     IEnumerator MunculVirus()
     {
        Instantiate(virus,transform.position + Vector.right* Random.Range(posisiMinimal,posisimaximal)
         , Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(waktuMinimal,waktuMaximal));
        StartCoroutine(MunculVirus());
     }
}
