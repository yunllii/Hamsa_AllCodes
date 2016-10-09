using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Next_Scene_Final : MonoBehaviour {
    public float waitTime;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Next());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Next()
    {
        // To be changed
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("01_Music");

    }
}
