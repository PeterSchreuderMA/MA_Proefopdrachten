using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum HealthTypes { Health, Cal, Fat, Protein };

public class PlayerHealthManager : MonoBehaviour
{
    [SerializeField]
    Slider sliderHealth;

    private GameObject player;
    private PersonObj person;

    //- Create the slider dictionary
    public Dictionary<string, Slider> uiSliders = new Dictionary<string, Slider>();

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void UpdateHealth(HealthTypes _type, float _value)
    {
        switch (_type)
        {
            case HealthTypes.Health:

            break;

            case HealthTypes.Cal://- Energy

                break;

            case HealthTypes.Fat://- Warmth slower

                float _current_amount = person.fat;


                person.fat += _value;

                break;

            case HealthTypes.Protein:

                break;
        }
    }
}
