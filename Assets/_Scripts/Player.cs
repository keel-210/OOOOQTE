using UnityEngine;
using DG.Tweening;
public class Player : MonoBehaviour
{
	[SerializeField] NotesManager notesManager;
	PlayerAction action;
	void Start()
	{
		notesManager.OnSuccess.AddListener(Action);
		notesManager.OnFailed.AddListener(ActionFailed);
		action = GetComponent<PlayerAction>();
	}
	public void Action(NoteEnum n)
	{
		if (NoteEnum.Up == n || NoteEnum.Down == n || NoteEnum.Left == n || NoteEnum.Right == n)
			action.Move(n);
		else
			action.Shot(n);
	}
	public void ActionFailed(NoteEnum n)
	{
		action.MoveFail(n);
	}
}
