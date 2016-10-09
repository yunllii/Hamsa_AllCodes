using UnityEngine;
using System.Collections;

public class playNote : MonoBehaviour {


    AudioSource do_note;
    bool pauseFinished = true;
	// Use this for initialization
	void Start () {
        do_note = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {



    }

    void OnCollisionEnter(Collision collision)
    {

        if (pauseFinished == true)
        {
            pauseFinished = false;
            do_note.Play();
            Debug.Log("Haha");
            StartCoroutine(Pause());
        }

    }

    IEnumerator Pause() {
        
        yield return new WaitForSeconds(0.2f);
        pauseFinished = true;

    }
}
