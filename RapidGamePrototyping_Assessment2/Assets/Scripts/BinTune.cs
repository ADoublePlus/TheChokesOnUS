using UnityEngine;
using System.Collections;

public class BinTune : MonoBehaviour
{
    private AudioSource audio;
    AudioClip trashBang;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bin")
        {
            StartCoroutine(Ding());
        }
    }

    IEnumerator Ding()
    {
        gameObject.SetActive(false);
        audio.PlayOneShot(trashBang);
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}