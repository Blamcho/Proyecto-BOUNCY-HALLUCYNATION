using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    private int _score;
    [SerializeField]  public TextMeshProUGUI _textscore;
    void Start()
    {
        _score = 0;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "coins")
            _score++;
        _textscore.text = "score " + _score;
    }
    
}
