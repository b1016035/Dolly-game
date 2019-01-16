using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IBM.Watson.DeveloperCloud.Services.SpeechToText.v1;
using IBM.Watson.DeveloperCloud.Connection;
using IBM.Watson.DeveloperCloud.Utilities;

public class ShipController : MonoBehaviour
{
    float wantRotation;
    public float turnTime = 1.0f;
    int c = 0;
    int c1 = 0;
    float speed = 30f;

    //[SerializeField] public ExampleStreaming anotherScript;
    public ExampleStreaming exampleStreaming;
    string resulttext;

    // Start is called before the first frame update
    void Start()
    {
        //anotherScript = GetComponent<ExampleStreaming>();
        wantRotation = transform.rotation.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.gameObject.transform.position;
        resulttext = exampleStreaming.text;

        Quaternion quaternion = this.transform.rotation;
        float y = quaternion.eulerAngles.y;

        if (pos.z <= 350 && c == 0)
        {
            this.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z + 10);

            if (pos.z >= 350){
                c++;
                Debug.Log(c);
            }
        }

        if (resulttext == "right" && c == 1)
        {
            Debug.Log(resulttext);
            c++;
            Debug.Log(c);
        }

        /*
        if(Input.GetKeyDown("right") && c == 1){
            c++;
        }

        if (Input.GetKeyDown("right") && c == 1)
        {
            c++;
            c1++;
        }*/

        if (c == 2)
        {
            float step = speed * Time.deltaTime;

            //指定した方向にゆっくり回転する場合
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 90f, 0), step);

            if (y >= 90){
                c++;
            }
        }

        if (pos.x <= 1500 && c == 3)
        {
            this.gameObject.transform.position = new Vector3(pos.x + 10, pos.y, pos.z);

            if (pos.x >= 1500)
            {
                c++;
            }
        }

        if (Input.GetKeyDown("left") && c == 4)
        {
            c++;
        }

        if (c == 5)
        {
            float step = speed * Time.deltaTime;

            //指定した方向にゆっくり回転する場合
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 0), step);

            if (y <= 0)
            {
                c++;
            }
        }

        if (pos.z <= 2300 && c == 6)
        {
            this.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z + 10);

            if (pos.z >= 2300)
            {
                c++;
            }
        }

        if (Input.GetKeyDown("left") && c == 7)
        {
            c++;
        }

        if (c == 8)
        {
            float step = speed * Time.deltaTime;

            //指定した方向にゆっくり回転する場合
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, -90, 0), step);

            if (270 <= y && y < 271)
            {
                c++;
            }
        }

        if (pos.x >= -2850 && c == 9)
        {
            this.gameObject.transform.position = new Vector3(pos.x - 10, pos.y, pos.z);

            if (pos.x <= -2850)
            {
                c++;
            }
        }

        if (c == 10)
        {
            float step = speed * Time.deltaTime;

            //指定した方向にゆっくり回転する場合
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, -150, 0), step);

            if (210 <= y && y < 211)
            {
                c++;
            }
        }

        Debug.Log(resulttext);
    }
}

