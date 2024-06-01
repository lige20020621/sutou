using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setting : MonoBehaviour
{
    public int lang = 0;
    public GameObject chineseButton;
    public GameObject englishButton;

    // Start is called before the first frame update
    void Start()
    {
        updateButton();
    }

    // Update is called once per frame
    void Update()
    {
        updateButton();
    }

    public void changeLanguage(int val)
    {
        lang = val;
    }

    void updateButton()
    {
        chineseButton.gameObject.SetActive(lang == 0);
        englishButton.gameObject.SetActive(!(lang == 0));
    }
}
