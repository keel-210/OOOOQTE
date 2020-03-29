using UnityEngine;
using System.Collections.Generic;
using DG.Tweening;
public class UIMovement : MonoBehaviour
{
	[SerializeField] NotesManager notesManager;
	List<RectTransform> list = new List<RectTransform>();
	void Start()
	{
		notesManager.OnFailed.AddListener(Shake);
	}
	public void Shake(NoteEnum n)
	{
		foreach (RectTransform t in list)
			t.DOShakePosition(0.5f);
	}
}