using UnityEngine;

namespace GeneralUI
{
	public class DialogueTrigger : MonoBehaviour {

		public Dialogue dialogue;

		public void TriggerDialogue ()
		{
			Debug.Log(dialogue.name + " start talking");
			FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
			FindObjectOfType<AudioManager>().Play("Modulo");
		}

		public void SetDialog(Dialogue dial)
		{
			this.dialogue = dial;
		}


	}
}
