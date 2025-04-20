using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    public GameObject flashBurstEffect;
    public GameObject fireballEffect;
    public GameObject debrisEffect;
    public GameObject smokeDustEffect;

    void Start()
    {
        AudioSource soundEffect = GameObject.Find("SoundSource")?.GetComponent<AudioSource>();

        if (flashBurstEffect != null)
            Invoke(nameof(spawnFlashBurst),0.6f);

        if (fireballEffect != null)
            Invoke(nameof(SpawnFireball), 0.6f);

        if (debrisEffect != null)
            Invoke(nameof(SpawnDebris), 0.7f);

        if (smokeDustEffect != null)
            Invoke(nameof(SpawnSmokeDust), 0.8f);

        if (soundEffect != null)
            soundEffect.Play();

        Destroy(gameObject, 6f);
    }

    void spawnFlashBurst() {
        GameObject flashClone = Instantiate(flashBurstEffect, transform.position, Quaternion.identity);
        Destroy(flashClone, 6f); 
    }
    void SpawnFireball()
    {
        GameObject fireballClone = Instantiate(fireballEffect, transform.position, Quaternion.identity);
        Destroy(fireballClone, 6f); 
    }

    void SpawnDebris()
    {
        GameObject debrisClone = Instantiate(debrisEffect, transform.position, Quaternion.identity);
        Destroy(debrisClone, 6f); 
    }

    void SpawnSmokeDust()
    {
        GameObject smokeDustClone = Instantiate(smokeDustEffect, transform.position, Quaternion.identity);
        Destroy(smokeDustClone, 6f);
    }
}