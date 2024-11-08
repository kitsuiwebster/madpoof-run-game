using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 5.0f; // Vitesse d'avancement
    public float sidewaysSpeed = 4.0f; // Vitesse de déplacement latéral

    void Update()
    {
        // Mouvement vers l'avant constant
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // Mouvement latéral
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * sidewaysSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * sidewaysSpeed * Time.deltaTime);
        }
    }
}

