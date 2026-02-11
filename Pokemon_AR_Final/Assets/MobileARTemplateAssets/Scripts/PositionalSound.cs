using UnityEngine;

public class PositionalSound : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void PlaySound()
    {
        if (audioSource == null) return;

        audioSource.Stop(); // optional: restart sound
        audioSource.Play();
    }

    public void StopSound()
    {
        if (audioSource == null) return;

        audioSource.Stop();
    }
}
