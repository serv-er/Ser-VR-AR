using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneman : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        Loadnextlevel();
    }
    public void Loadnextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
