using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Scene00ButtonHandler : MonoBehaviour
{
    private Button _changeToScene01Button;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        _changeToScene01Button = root.Q<Button>("ChangeToScene01Button");
        if(_changeToScene01Button !=null)
        {
            _changeToScene01Button.clicked += ChangeToScene01;
        }
    }

    private void OnDisable()
    {
        if(_changeToScene01Button !=null)
        {
            _changeToScene01Button.clicked -= ChangeToScene01;
        }
    }

    private void ChangeToScene01()
    {
        SceneManager.LoadScene(1); // Loads scene at index 1
        // You can also pass it the name of the scene ("Scene01")
    }
}
