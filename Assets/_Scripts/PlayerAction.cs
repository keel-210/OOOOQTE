using UnityEngine;
using DG.Tweening;
public class PlayerAction : MonoBehaviour
{
	public Vector3 VerticalMoveVector = new Vector3(0, 1f, 0), HorizontalMoveVector = new Vector3(2f, 0, 0);
	public void Move(NoteEnum n)
	{
		switch (n)
		{
			case NoteEnum.Up:
				if (transform.localPosition.y == 0)
					transform.DOLocalMove(transform.localPosition + VerticalMoveVector, 0.2f).SetEase(Ease.InSine);
				transform.DORotate(Vector3.forward * 360f, 0.2f, RotateMode.FastBeyond360).SetEase(Ease.InSine);
				break;
			case NoteEnum.Down:
				if (transform.localPosition.y == 1.5f)
					transform.DOLocalMove(transform.localPosition - VerticalMoveVector, 0.2f).SetEase(Ease.InSine);
				transform.DORotate(Vector3.forward * 360f, 0.2f, RotateMode.FastBeyond360).SetEase(Ease.InSine);
				break;
			case NoteEnum.Right:
				if (transform.localPosition.x != 3f)
					transform.DOLocalMove(transform.localPosition + HorizontalMoveVector, 0.2f).SetEase(Ease.InSine);
				transform.DORotate(Vector3.forward * 360f, 0.2f, RotateMode.FastBeyond360).SetEase(Ease.InSine);
				break;
			case NoteEnum.Left:
				if (transform.localPosition.x != -3f)
					transform.DOLocalMove(transform.localPosition - HorizontalMoveVector, 0.2f).SetEase(Ease.InSine);
				transform.DORotate(Vector3.forward * 360f, 0.2f, RotateMode.FastBeyond360).SetEase(Ease.InSine);
				break;
		}
	}
	public void MoveFail(NoteEnum n)
	{
		switch (n)
		{
			case NoteEnum.Up:
				if (transform.localPosition.y == 0)
					transform.DOLocalMove(transform.localPosition + VerticalMoveVector, 0.2f).SetEase(Ease.InSine);
				break;
			case NoteEnum.Down:
				if (transform.localPosition.y == 1.5f)
					transform.DOLocalMove(transform.localPosition - VerticalMoveVector, 0.2f).SetEase(Ease.InSine);
				break;
			case NoteEnum.Right:
				if (transform.localPosition.x != 3f)
					transform.DOLocalMove(transform.localPosition + HorizontalMoveVector, 0.2f).SetEase(Ease.InSine);
				break;
			case NoteEnum.Left:
				if (transform.localPosition.x != -3f)
					transform.DOLocalMove(transform.localPosition - HorizontalMoveVector, 0.2f).SetEase(Ease.InSine);
				break;
		}
	}
	public void Shot(NoteEnum n)
	{
		switch (n)
		{
			case NoteEnum.Cross:
				break;
			case NoteEnum.Triangle:
				break;
			case NoteEnum.Circle:
				break;
			case NoteEnum.Rectangle:
				break;
		}
	}
}
