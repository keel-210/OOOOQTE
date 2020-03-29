using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineImpulseSource))]
public class CameraShaker : MonoBehaviour
{
	[SerializeField] float ShakeStrength = 10;
	CinemachineImpulseSource impulseSource;
	void Start()
	{
		NotesManager m = FindObjectOfType<NotesManager>();
		m.OnFailed.AddListener(Shake);
		impulseSource = GetComponent<CinemachineImpulseSource>();
	}
	void Shake(NoteEnum n)
	{
		impulseSource.GenerateImpulseAt(Vector3.one, Vector3.one * ShakeStrength);
	}
}