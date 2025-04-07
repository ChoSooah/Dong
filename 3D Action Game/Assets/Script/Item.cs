using UnityEngine;

public class Item : MonoBehaviour
{
    public enum Tyep { Ammo, Coin, Grenade, Heart, Weapon };
    public Tyep tyep;
    public int value;

    void Update()
    {
        transform.Rotate(Vector3.up * 20 * Time.deltaTime);
        }

}
