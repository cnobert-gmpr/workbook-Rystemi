using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Scene_01UI : MonoBehaviour
{
    private Button _buttonChangeToScene02;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        _buttonChangeToScene02 = root.Q<Button>("buttonOpenScene02");
        if(_buttonChangeToScene02 !=null)
        {
            _buttonChangeToScene02.clicked += ChangeToScene02;
        }
    }

    private void OnDisable()
    {
        if(_buttonChangeToScene02 !=null)
        {
            _buttonChangeToScene02.clicked -= ChangeToScene02;
        }
    }

    private void ChangeToScene02()
    {
        SceneManager.LoadScene(2); // Loads scene at index 1
        // You can also pass it the name of the scene ("Scene01")
    }
}
