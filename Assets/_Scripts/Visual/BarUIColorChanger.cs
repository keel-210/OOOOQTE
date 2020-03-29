using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class BarUIColorChanger : MonoBehaviour
{
	[SerializeField] Graphic graphic;
	[SerializeField] Color[] colors;
	public float Time = 0.2f;
	int index = 0;
	void Update()
	{
		if (Music.IsPlaying && Music.IsJustChangedBar())
		{
			graphic.DOColor(colors[index], Time);
			index++;
			if (colors.Length == index)
				index = 0;
		}
	}
}