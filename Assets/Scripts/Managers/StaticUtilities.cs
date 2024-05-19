using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticUtilities : MonoBehaviour
{
    public static readonly int xSpeedID = Animator.StringToHash("xSpeed");
    public static readonly int ySpeedID = Animator.StringToHash("ySpeed");
    public static readonly int JumpID = Animator.StringToHash("Jump");

    public static readonly int GroundLayers = 1 << LayerMask.NameToLayer("Ground");
    public static readonly int DeafultLayers = 1 << LayerMask.NameToLayer("Default");
    public static readonly int GroundCheckLayers = GroundLayers | DeafultLayers;
}
