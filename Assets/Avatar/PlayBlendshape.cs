using UnityEngine;

public class PlayBlendshape : MonoBehaviour
{
    public SkinnedMeshRenderer skinnedMesh;
    public int blendIndex = 0;
    public float targetWeight = 100f;

    void Start()
    {
        if (skinnedMesh == null) skinnedMesh = GetComponentInChildren<SkinnedMeshRenderer>();
        if (skinnedMesh != null)
            skinnedMesh.SetBlendShapeWeight(blendIndex, targetWeight);
    }
}