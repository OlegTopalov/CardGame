using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MessageManager : MonoBehaviour 
{
    public Text MessageText;
    public GameObject MessagePanel;
	public CanvasGroup cg;
    public static MessageManager Instance;

    void Awake()
    {
        Instance = this;
        MessagePanel.SetActive(false);
    }


    public void ShowMessage(string Message, float Duration )
    {
        StartCoroutine(ShowMessageCoroutine(Message, Duration));
    }

    IEnumerator ShowMessageCoroutine(string Message, float Duration)
    {
        //Debug.Log("Showing some message. Duration: " + Duration);
		cg.alpha = 0f;
		MessageText.text = Message;
		MessagePanel.SetActive(true);
		while (cg.alpha < 1f)
		{
			cg.alpha += 0.1f;
			yield return new WaitForSeconds(0.05f);
		}
      

        yield return new WaitForSeconds(Duration);

		while (cg.alpha > 0)
		{
			cg.alpha -= 0.1f;
			yield return new WaitForSeconds(0.05f);
		}
        MessagePanel.SetActive(false);
        //Command.CommandExecutionComplete();
    }
}
