using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBS : MonoBehaviour
{
    public float Velocidad = 5f;
    public float TiempoVida = 0f;
    public float TiempoMaximoVida = 10f;

    void Update()
    {
        transform.Translate(Vector3.left * Velocidad * Time.deltaTime);
        TiempoVida += Time.deltaTime;

        if (TiempoVida > TiempoMaximoVida)
        {
            Destroy(gameObject);
        }
    }
}
