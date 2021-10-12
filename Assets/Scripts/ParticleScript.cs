using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public GameObject triggerParticle;
    public GameObject collisionParticle;
    // Start is called before the first frame update
    private void OnTriggervoidEnter(Collider Floor)
    {
        if (triggerParticle != null)
        {
            Instantiate(triggerParticle, this.transform.position, this.transform.rotation );
        }
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collisionParticle != null)
        Instantiate(collisionParticle, collision.contacts[0].point, this.transform.rotation);
    }
}
