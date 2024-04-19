using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MN_PlayerMovement))]
public class SY_HorizontalMovement : MonoBehaviour
{
    [SerializeField] private KeyCode[] mvmInputs;
    [SerializeField] private float[] mvmStats;
    [SerializeField] private GameObject orientation;

    public Vector3 horizontalVelocity;
    private float veclocityX = 0 , veclocityZ = 0;



    public void setData(KeyCode[] keys, float[] stats)
    {
        mvmInputs = keys;
        mvmStats = stats;
    }

    public void M_Update()
    {
        move();
    }

    /// <summary>
    /// get player inputs and convert them to a vector
    /// </summary>
    /// <returns></returns>
    public Vector2 inputDir()
    {
        Vector2 dir = Vector2.zero;

        if (Input.GetKey(mvmInputs[0])) { dir.x = 1; }
        else if (Input.GetKey(mvmInputs[1])) { dir.x = -1; }
        else { dir.x = 0; }

        if (Input.GetKey(mvmInputs[2])) { dir.y = 1; }
        else if (Input.GetKey(mvmInputs[3])) { dir.y = -1; }
        else { dir.y = 0; }

        return dir;
    }

    public void move()
    {

        Vector3 inputDirection = new Vector3(inputDir().x, 0, inputDir().y);

        // ++ movement on global X axis ++
        if (inputDirection.x > 0 && veclocityX < mvmStats[0]) { veclocityX += mvmStats[1]; } // move forward
        else if (inputDirection.x < 0 && veclocityX > -mvmStats[0]) { veclocityX -= mvmStats[1]; } // move backward
        else if (inputDirection.x == 0)
        { veclocityX = Mathf.Lerp(veclocityX, 0, mvmStats[2]); } // if idle input on x axis , slow down on this axis

        // ++ movement on global z axis ++
        if (inputDirection.z > 0 && veclocityZ < mvmStats[0]) { veclocityZ += mvmStats[1]; } // move forward
        else if (inputDirection.z < 0 && veclocityZ > -mvmStats[0]) { veclocityZ -= mvmStats[1]; } // move backward
        else if (inputDirection.z == 0)
        { veclocityZ = Mathf.Lerp(veclocityZ,0 , mvmStats[2]); } // if idle input on x axis , slow down on this axis

        horizontalVelocity = Vector3.Lerp( transform.TransformDirection(new Vector3(veclocityX, 0, veclocityZ)), Vector3.zero, mvmStats[2]);

        
    }
}
