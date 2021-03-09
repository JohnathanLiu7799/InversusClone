using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private bool isStart;
    [SerializeField] private bool isQuit;
    [SerializeField] private bool isPlayAgain;
    [SerializeField] private bool isReturnMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseUp()
    {
        if (isStart) { Application.LoadLevel(1); }
        if (isQuit) { Application.Quit(); }
        if (isPlayAgain) { Application.LoadLevel(1); }
        if (isReturnMenu) { Application.LoadLevel(0); }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
