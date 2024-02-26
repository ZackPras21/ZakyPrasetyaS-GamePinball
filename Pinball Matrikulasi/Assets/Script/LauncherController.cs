using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public Collider bola;
    public KeyCode input;

    public float maxTimeHold;
    public float maxForce;

    public Material holdMaterial; 

    private Renderer renderer;
    private bool isHold;

    private Material originalMaterial; 

    private void Start()
    {
        isHold = false;
        renderer = GetComponent<Renderer>();
        originalMaterial = renderer.material; 
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider == bola)
        {
            ReadInput(bola);
        }
    }

    private void ReadInput(Collider collider)
    {
        if (Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(collider));
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;

        // Ganti material saat tombol ditekan
        renderer.material = holdMaterial;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold / maxTimeHold);

            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }

        collider.GetComponent<Rigidbody>().AddForce(transform.forward * force);
        isHold = false;

        // Kembalikan material asli saat tombol dilepas
        renderer.material = originalMaterial;
    }
}