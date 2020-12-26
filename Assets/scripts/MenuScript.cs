using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

    public Button Playgame;
    public Button AboutUs;
    public Button Settings;
    public Button Exit;

    

    // Start is called before the first frame update
    void Start()
    {

        Playgame.onclick.AddListener(() =>
        {
            Application.LoadLevel("");

        });
        AboutUs.onclick.AddListener(() =>
        {


        });
        Settings.onclick.AddListener(() =>
        {


        });
        Exit.onclick.AddListener(() =>
        {
            Application.Quit;
        

        });


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
