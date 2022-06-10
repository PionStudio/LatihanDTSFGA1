using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private Text gawangKiriText;
    [SerializeField] private Text gawangKananText;

    private int skorKiri;
    private int skorKanan;

    [SerializeField] private int maxScore;

    // Update is called once per frame
    void Update()
    {
        gawangKananText.text = skorKanan.ToString();
        gawangKiriText.text = skorKiri.ToString();

        if ((skorKiri >= maxScore) || (skorKanan >= maxScore))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }

    public void CetakGoal(bool kiriGawang)
    {
        if (kiriGawang)
        {
            skorKiri++;
            return;
        }

        skorKanan++;
    }
}
