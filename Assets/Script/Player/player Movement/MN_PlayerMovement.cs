using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MN_PlayerMovement : CL_Manager
{
    [SerializeField] private SY_HorizontalMovement horizontalmvm;
    [SerializeField] private SY_PlayerRotation rotation;
    [SerializeField] private SY_groundCheck ground;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private SY_VerticalMovement verticalmvm;

    private void Awake()
    {
        KeyCode[] hrkeys = MN_GeneralManager.GetManagerfromGeneral<MN_PlayerData>().getHorizontalMovementInput();
        float[] horizontalStats = MN_GeneralManager.GetManagerfromGeneral<MN_PlayerData>().getHorizontalMovementStats();
        
        KeyCode jumpKey = MN_GeneralManager.GetManagerfromGeneral<MN_PlayerData>().getVerticalInput();
        float[] vertivalStats = MN_GeneralManager.GetManagerfromGeneral<MN_PlayerData>().getVerticalStats();

        horizontalmvm.setData(hrkeys, horizontalStats);
        verticalmvm.setData(jumpKey,new float[] { vertivalStats[0], vertivalStats[1] }, Mathf.RoundToInt( vertivalStats[2]));
        
        rb = GetComponentInParent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        horizontalmvm.M_Update();
        rotation.M_Update();
        ground.M_Update();
        verticalmvm.M_Update();
        applyMovement();
    }

    private void applyMovement()
    {
        rb.velocity = horizontalmvm.horizontalVelocity + verticalmvm.veritcallVelocity;
    }
}
