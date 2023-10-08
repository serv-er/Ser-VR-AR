using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ldscene : MonoBehaviour
{
    public string scn;

    void Update()
    {
        Loadnextlevel();
    }
    public void Loadnextlevel()
    {
        SceneManager.LoadScene(scn);
    }

}
