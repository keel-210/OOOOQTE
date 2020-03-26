using UnityEngine;
using System.Collections.Generic;
using DG.Tweening;
public class UIMovement : MonoBehaviour
{
	List<RectTransform> list = new List<RectTransform>();
	public void Shake()
	{
		foreach (RectTransform t in list)
			t.DOShakePosition(0.5f);
	}
}