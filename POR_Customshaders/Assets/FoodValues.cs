using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FoodValues : MonoBehaviour
{
    public Food foodObj;

    public Action<HealthTypes, float> OnPlayerPickup;

    // Start is called before the first frame update
    void Start()
    {
        float _scale = 1.5f;

        GameObject _model = Instantiate<GameObject>(foodObj.model);
        _model.transform.SetParent(gameObject.transform.GetChild(0));
        _model.transform.localPosition = new Vector3(0, 0, 0);
        _model.transform.localScale = new Vector3(_scale, _scale, _scale);
    }



    void OnTriggerEnter(Collider _col)
    {
        if (_col.CompareTag("Player"))
        {
            Consume();
        }
    }



    void Consume()
    {
        StartCoroutine(ConsumeAni());
        OnPlayerPickup?.Invoke(HealthTypes.Health, foodObj.health);
    }

    IEnumerator ConsumeAni()
    {
        //float _endScale = 0.4f;
        //transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(_endScale, _endScale, _endScale), 2f);

        yield return new WaitForSeconds(1f);

        GameObject.Destroy(gameObject);

        
    }





    void Subscribe()
    {
        OnPlayerPickup += FindObjectOfType<PlayerHealthManager>().UpdateHealth;
    }

    void UnSubscribe()
    {
        OnPlayerPickup -= FindObjectOfType<PlayerHealthManager>().UpdateHealth;
    }
}
