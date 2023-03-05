using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_InputField inputField;
    [HideInInspector]public static string userName;

    // Start is called before the first frame update
    void Start()
    {
        // ��� ����������� ����, ������������ ������ ��������� ��'�
        string lastUserName = PlayerPrefs.GetString("Username", "");
        inputField.text = lastUserName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartButtonClick()
    {
        // �������� ����� � InputField
        userName = inputField.text;
        // �������� ��'� ����������� � PlayerPrefs
        PlayerPrefs.SetString("Username", userName);
        SceneManager.LoadScene(1);
    }
}
