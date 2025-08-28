using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletText : MonoBehaviour
{
    public Text bulletText;
    public int bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bulletText.text = bullet.ToString();
    }
    public void AddBullet()
    {
        bullet+=10;
    }
}
