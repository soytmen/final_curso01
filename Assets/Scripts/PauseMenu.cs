using UnityEngine;


public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject GameUI;


    // Update is called once per frame

    private void Start()
    {
        PausePanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (PausePanel.activeInHierarchy)
            {

                pauseStop();
                GameUI.SetActive(true);
             
            }
            else 
            {

                pause();
                GameUI.SetActive(false);

            }
        }
        
    }
   public void pause ()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        PausePanel.SetActive(true);
        Debug.Log(PausePanel.activeInHierarchy);
        Time.timeScale = 0;
    }
    public void pauseStop()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        PausePanel.SetActive(false);
        Debug.Log(PausePanel.activeInHierarchy);

        Time.timeScale = 1;
    }
}
