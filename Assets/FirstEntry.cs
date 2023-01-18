using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class FirstEntry : MonoBehaviour
{

    [SerializeField] Button EN;
    [SerializeField] Button TR;
    [SerializeField] GameObject Toggle;

    void Start()
    {
        if (PlayerPrefs.GetInt("first")==0)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            this.gameObject.GetComponent<Image>().enabled = true;
        }
        else 
        {
            this.gameObject.SetActive(true);
        }
       
    }

    
    public void ToggleOn() 
    {
        if (Toggle.GetComponent<Toggle>().isOn) 
        {
            TR.interactable = true;
            EN.interactable = true;
        }
        else 
        {
            TR.interactable = false;
            EN.interactable = false;
        }
        
    }

    public void Tr_language()
    {
            PlayerPrefs.SetInt("first", 1);
        PlayerPrefs.SetString("language", "tr");
        Continue();
    }

    public void En_language()
    {
            PlayerPrefs.SetInt("first", 1);
        PlayerPrefs.SetString("language", "en");
        Continue();
    }

    void Continue() 
    {
        this.gameObject.GetComponent<Image>().DOColor(Color.black, 2).OnComplete(()=> SceneManager.LoadScene(0));
    }
}
