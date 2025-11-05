using UnityEngine;

public class Orbits : MonoBehaviour
{
    //Centre de l�orbite (ex: le Soleil)
    public Transform pivot;

    //Vitesse angulaire en degr�s/seconde
    public float angularSpeed = 20f;

    //Rotation propre de la plan�te en degr�s/seconde
    public float selfRotationSpeed = 30f;

    void Update()
    {
        if (pivot != null)
        {
            // orbite autour du pivot (axe Y)
            transform.RotateAround(pivot.position, Vector3.up, angularSpeed * Time.deltaTime);
        }
        // rotation sur soi-m�me (axe Y)
        transform.Rotate(Vector3.up, selfRotationSpeed * Time.deltaTime, Space.Self);
    }
}
