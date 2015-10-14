using UnityEngine;
using System.Collections;

public class AttackEffects : MonoBehaviour {


    public Transform _myTransform;
    public float growRate = 0.5f;
    public float explodeRate = 10f;
    public bool charging;

    // Use this for initialization
    void Start () {
        _myTransform = transform;
        transform.localScale = new Vector3(10f, 10f, 10f);
    }
	
	// Update is called once per frame
	void Update () {
        if (!charging)
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            Material material = renderer.material;
            Color color = renderer.material.color;
            color.a = 0.0f;
            renderer.material.color = color;
            _myTransform.localScale = new Vector3(10f, 10f, 10f);
        }
        else if (charging)
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            Material material = renderer.material;
            Color color = renderer.material.color;
            if (color.a < 0.6f)
            {
                color.a += 0.01f;
            }
            renderer.material.color = color;
            transform.Rotate(5, 5, 5);
            transform.localScale -= new Vector3(growRate, growRate, growRate);
            if(_myTransform.localScale.x < 1){
                
                LocalResetSphere();
            }
        }
    }

    public void ResetSphere()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        Material material = renderer.material;
        Color color = renderer.material.color;
        color.a = 0.0f;
        renderer.material.color = color;
        _myTransform.localScale = new Vector3(10f, 10f, 10f);
        gameObject.SetActive(false);
    }

    public void LocalResetSphere(){
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        Material material = renderer.material;
        Color color = renderer.material.color;
        color.a = 0.0f;
        renderer.material.color = color;
        _myTransform.localScale = new Vector3(10f, 10f, 10f);
    }
}
