using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private UIDocument document;
    private Button botaoJogar;

    void OnPlayGame(ClickEvent evt)
    {
        SceneManager.LoadScene("Main");
    }
    private void Awake()
    {
        document = GetComponent<UIDocument>();
        botaoJogar = document.rootVisualElement.Q<Button>("btnjogar");
        botaoJogar.RegisterCallback<ClickEvent>(OnPlayGame);
    }
    
}
