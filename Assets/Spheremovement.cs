using UnityEngine;
using System.Collections;

public class Spheremovement : MonoBehaviour
{
    public GameObject sphere1;
    public int loopCount = 1;
    public float speed;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key is pressed.");
            if (loopCount % 2 != 0)
            {
                sphere1.transform.eulerAngles = new Vector3(0, 45, 0);
                loopCount++;
            }
            
            else
            {
                sphere1.transform.eulerAngles = new Vector3(0, -45, 0);
                loopCount++;
            }
        }
    }
}