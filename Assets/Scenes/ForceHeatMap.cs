using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceHeatMap : MonoBehaviour
{
    private Material material;
    private Color previousColor;
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<SkinnedMeshRenderer>().sharedMaterial;
        previousColor = material.GetColor("_BaseColor");
	  material.SetColor("_RippleCenter", previousColor);
    }

    void onCollisionEnter(Collision collisionInfo) {
        StartRipple(collisionInfo.contacts[0].point);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StartRipple(Vector3 center) {
        Color randomColor = Color.HSVToRGB(Random.value, 1, 1);
        material.SetColor("_BaseColor", previousColor);
        material.SetColor("_RippleColor", randomColor);
	  previousColor = randomColor;
        material.SetVector("_RippleCenter", center);
    }
}
