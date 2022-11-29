using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    private int _score;
    [SerializeField] public TextMeshProUGUI _textscore = default;
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
