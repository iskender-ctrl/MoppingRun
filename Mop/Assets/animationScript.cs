using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationScript : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public GameObject paspas;
    public GameObject player;
    public Rigidbody rb;
    public float speed = 40f;
    public Camera cam;
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.FindWithTag("Cylinder").transform.rotation = Quaternion.Euler(-90f, 0f, 0);
            GameObject.Find("mop_run-yeni karakter2").transform.position += new Vector3(0f, 0.029f, 0.85f);
            anim.SetBool("Slimb", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.FindWithTag("Cylinder").transform.rotation = Quaternion.Euler(-109.2f, 0, 0);
            GameObject.Find("mop_run-yeni karakter2").transform.position -= new Vector3(0f, 0.029f, 0.85f);
            anim.SetBool("Slimb", false);
        }
    }
}
