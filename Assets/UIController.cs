using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] private Transform _canvasParentTramsform;
    [SerializeField] private GameObject _uiPopupMenu;

    private bool _isPause;
    void Start()
    {
        GameObject popupMenu = Instantiate(_uiPopupMenu, _canvasParentTramsform, false);
        RectTransform rectTransform = popupMenu.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = Vector2.zero;
        rectTransform.sizeDelta = new Vector2(500, 400);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
