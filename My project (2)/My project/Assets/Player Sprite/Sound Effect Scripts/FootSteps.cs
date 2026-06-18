using UnityEngine;

public class FootSteps : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;

    public AudioClip[] footstepSounds;
    readonly string animParam_Run = "Running";

    public bool Running = false;

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool(animParam_Run, Running);
    }

    public void Footstep()
    {
        int random = Random.Range(0, footstepSounds.Length);
        var clip = footstepSounds[random];
        audioSource.PlayOneShot(clip);
    }
}
