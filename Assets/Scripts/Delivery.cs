using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] private float _destroyPackageWaitTime = 1.0f;
    [SerializeField] private Color32 _hasPackageColour = new Color32(1, 1, 1, 1);
    [SerializeField] private Color32 _noPackageColour = new Color32(0, 0, 0, 1);
    private SpriteRenderer _packageDeliveryStatusSpriteRenderer;
    private bool _hasPackage;

    
    // Start is called before the first frame update
    void Start()
    {
        _packageDeliveryStatusSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Great job, you just hit something");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package") && !_hasPackage)
        {
            Debug.Log("Woohoo, you picked up a package");
            _packageDeliveryStatusSpriteRenderer.color = _hasPackageColour;
            _hasPackage = true;
            Destroy(collision.gameObject, _destroyPackageWaitTime);
        }
        if (collision.CompareTag("Customer") && _hasPackage)
        {
            Debug.Log("Well Done, you delivered the package");
            _packageDeliveryStatusSpriteRenderer.color = _noPackageColour;
            _hasPackage = false;
        }
    }
}
