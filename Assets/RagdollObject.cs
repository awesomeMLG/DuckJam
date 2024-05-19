using System;
using UnityEngine;
using UnityEngine.U2D.IK;

public class RagdollObject : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private HingeJoint2D[] hinges;
    [SerializeField] private Collider2D[] colliders;
    [SerializeField] private Rigidbody2D[] rbs;
    [SerializeField] private LimbSet[] limbs;

    public bool IsRagDolled {get; private set;}
    
    #if UNITY_EDITOR
    [ContextMenu("ActivateRagDoll")]
    public void ActivateRagDoll_EditorOnly()
    {
        SetRagdollState(true);
    }

    [ContextMenu("DisableRagDoll")]
    public void DeactivateRagDoll_EditorOnly()
    {
        SetRagdollState(false);
    }
    #endif

    public void SetRagdollState(bool isRagDolled){
        IsRagDolled = isRagDolled;

        animator.enabled = !isRagDolled;
        foreach (var component in hinges) component.enabled = isRagDolled;
        foreach (var component in colliders) component.enabled = isRagDolled;
        foreach (var rb in rbs) rb.simulated = isRagDolled;
        foreach (var limbSet in limbs)
        {
            float w = isRagDolled ? limbSet.ragDollWeight : limbSet.rigidWeight;
            foreach (var limb in limbSet.limbs) limb.weight = w;
        }
    }


    [Serializable]
    private struct LimbSet
    {
        public LimbSolver2D[] limbs;
        [Min(0)] public float ragDollWeight;
        [Min(0)] public float rigidWeight;
    }
}
