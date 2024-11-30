using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedObjects : MonoBehaviour
{
    public GameObject windmill, cloud1, cloud2, cloud3, cloud4, cloud5, cloud6;
    public float rotationSpeed;
    public float cloud1Speed, cloud2Speed, cloud3Speed, cloud4Speed, cloud5Speed, cloud6Speed;
    public Vector2 cloud1Pos, cloud2Pos, cloud3Pos, cloud4Pos, cloud5Pos, cloud6Pos, dustBallPos;

    public float dustBallMoveSpeed, dustBallRotationSpeeD;
    public GameObject dustball;

    void Start()
    {
        rotationSpeed = 3.3f;
        cloud1Speed = 0.9f;
        cloud2Speed = 1.4f;
        cloud3Speed = 1.6f;
        cloud4Speed = 0.45f;
        cloud5Speed = 1.2f;
        cloud6Speed = 0.8f;
    }

    void Update()
    {
        dustball.transform.Translate(Vector3.right * dustBallMoveSpeed * Time.deltaTime, Space.World);
        dustball.transform.Rotate(0f, 0f, -dustBallRotationSpeeD * Time.deltaTime);

        windmill.transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
        cloud1.transform.Translate(Vector3.right * cloud1Speed * Time.deltaTime);
        cloud2.transform.Translate(Vector3.right * cloud2Speed * Time.deltaTime);
        cloud3.transform.Translate(Vector3.right * cloud3Speed * Time.deltaTime);
        cloud4.transform.Translate(Vector3.right * cloud4Speed * Time.deltaTime);
        cloud5.transform.Translate(Vector3.right * cloud5Speed * Time.deltaTime);
        cloud6.transform.Translate(Vector3.right * cloud6Speed * Time.deltaTime);

        cloud1Pos = cloud1.transform.position;
        cloud2Pos = cloud2.transform.position;
        cloud3Pos = cloud3.transform.position;
        cloud4Pos = cloud4.transform.position;
        cloud5Pos = cloud5.transform.position;
        cloud6Pos = cloud6.transform.position;

        dustBallPos = dustball.transform.position;

        if (dustBallPos.x > 82)
        {
            dustball.transform.position = new Vector2(-82, -16.45f);
        }

        if (cloud1Pos.x > 89)
        {
            cloud1.transform.position = new Vector2(-89,10.6f);
        }
        if (cloud2Pos.x > 85)
        {
            cloud2.transform.position = new Vector2(-85, 15.1f);
        }
        if (cloud3Pos.x > 85)
        {
            cloud3.transform.position = new Vector2(-85, 6.7f);
        }
        if (cloud4Pos.x > 96)
        {
            cloud4.transform.position = new Vector2(-96, 13.3f);
        }
        if (cloud5Pos.x > 85)
        {
            cloud5.transform.position = new Vector2(-85, 15);
        }
        if (cloud6Pos.x > 90)
        {
            cloud6.transform.position = new Vector2(-90, 7.3f);
        }
    }
}
