using UnityEngine;
using TMPro;

public class IteamUIManager : MonoBehaviour
{
    public static IteamUIManager instance;

    // Số lượng
    int Bullet = 0;
    int ShotGun = 0;
    int Nade = 0;
    int Gun = 0;

    // UI hiển thị
    [Header("UI Text")]
    public TMP_Text bulletText;
    public TMP_Text shotGunText;
    public TMP_Text nadeText;
    public TMP_Text gunText;

    private void Awake()
    {
        instance = this;
    }

   
    public void UpdateUI()
    {
        if (bulletText) bulletText.text = Bullet.ToString();
        if (shotGunText) shotGunText.text = ShotGun.ToString();
        if (nadeText) nadeText.text = Nade.ToString();
        if (gunText) gunText.text = Gun.ToString();
    }
    public void AddBullet(int value)
    {
        Bullet += value;
        UpdateUI();
    }
    public void AddShotGun(int value)
    {
        ShotGun += value;
        UpdateUI();
    }
    public void AddNade(int value)
    {
        Nade += value;
        UpdateUI();
    }
    public void AddGun(int value)
    {
        Gun += value;
        UpdateUI();
    }
}
