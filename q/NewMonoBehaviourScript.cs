using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Slider myslider;
    private GameObject[] enemies;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("q");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(myslider.value);    
        if (myslider.value <= 8)
        {
            float q = 34 * myslider.value;
            foreach (GameObject enemy in enemies)
            {
                enemy.SetActive(true);
                //if (q <= 0)
                //{
                //    break;

                //}
                //else
                //{
                //    enemy.SetActive(true);
                //    q -= 1;
                //}
            }
        }
    }
}
