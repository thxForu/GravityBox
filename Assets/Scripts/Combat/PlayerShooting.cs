using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float recoilPower;
    [SerializeField] private Transform shootPosition;
    
    private Rigidbody2D _rb;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        LookAtMouse();
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
            Recoil();
        }
    }

    private void Shoot()
    {
        Instantiate(bullet, shootPosition.position, transform.rotation);
    }

    private void Recoil()
    {
        _rb.AddForce(transform.right *-1*recoilPower);
    }

    private void LookAtMouse()
    {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
