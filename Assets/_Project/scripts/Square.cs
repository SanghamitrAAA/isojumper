using UnityEngine;

public class Square : MonoBehaviour
{
    [SerializeField] Material _squareMaterial;
    [SerializeField] Renderer _squareRenderer;

    void start()
    {
        //transform.Rotate(0, 90,0);
        //transform.rotation = Quaternion.Euler(0, 90, 0);
    }


    void OnEnable()
    {
        transform.rotation = Quaternion.Euler(0, 90, 0);
        _squareRenderer.material = _squareMaterial;
    } 

}
