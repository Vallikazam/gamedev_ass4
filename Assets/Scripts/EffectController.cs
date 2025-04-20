using UnityEngine;

public class EffectController : MonoBehaviour
{
    public GameObject flashBurstEffect;
    public GameObject fireballEffect;
    public GameObject debrisEffect;
    public GameObject smokeDustEffect;
    public GameObject explosionEffect;
    public AudioSource soundEffect;

    public void TriggerFlashBurst()
    {
        if (flashBurstEffect != null)
        {
            GameObject effect = Instantiate(flashBurstEffect, Vector3.zero, Quaternion.identity);
            Destroy(effect, 3f);
        }
    }

    public void TriggerFireball()
    {
        if (fireballEffect != null)
        {
            GameObject effect = Instantiate(fireballEffect, Vector3.zero, Quaternion.identity);
            Destroy(effect, 3f);
        }
    }

    public void TriggerDebris()
    {
        if (debrisEffect != null)
        {
            GameObject effect = Instantiate(debrisEffect, Vector3.zero, Quaternion.identity);
            Destroy(effect, 3f);
        }
    }

    public void TriggerSmokeDust()
    {
        if (smokeDustEffect != null)
        {
            GameObject effect = Instantiate(smokeDustEffect, Vector3.zero, Quaternion.identity);
            Destroy(effect, 3f);
        }
    }

    public void TriggerSound()
    {
        if (soundEffect != null)
        {
            soundEffect.Play();
        }
    }

    public void TriggerExplosion()
    {
        if (explosionEffect != null)
        {
            GameObject effect = Instantiate(explosionEffect, Vector3.zero, Quaternion.identity);
        }
    }
}