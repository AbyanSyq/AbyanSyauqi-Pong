
using UnityEditor.UIElements;
using UnityEngine;

public class Author : MonoBehaviour
{
    [SerializeField]GameObject authorPanel;
        private void Update() {
                clodeAuthorPanel();
        }

    public void openAuthorPanel(){
        authorPanel.SetActive(true);
    }
    public void clodeAuthorPanel(){
        if(Input.GetKeyDown(KeyCode.Escape)){
                authorPanel.SetActive(false);
        }
    }
}
