using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HoleManager : MonoBehaviour
{
    private float circleCapacity;
    [SerializeField] private Image circleImg;
    [SerializeField] private Transform holeGameObj;

    [Serializable]
    public class HoleSizeClass
    {
        public Vector3 size;
    }

    [SerializeField] private CameraManager cameraManager;
    HoleSizeClass _holeSizeClass = new HoleSizeClass();

    private void ProgressBarCircle(int number)
    {
        circleCapacity = 1f / number;

        circleImg.fillAmount += circleCapacity;

        if (circleImg.fillAmount.Equals(1f))
        {
            holeGameObj.localScale += new Vector3(0.5f, 0f, 0.5f);
            cameraManager.AddOffset(new Vector3(0, 0.5f*2, -0.5f*2));
            circleImg.fillAmount = 0f;

            _holeSizeClass.size = holeGameObj.localScale;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ammo"))
        {
            Debug.Log("Va Cham");
            ProgressBarCircle(20);
            IteamUIManager.instance.AddBullet(1);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("shotgun"))
        {
            Debug.Log("Va Cham");
            ProgressBarCircle(15);
            IteamUIManager.instance.AddShotGun(1);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("nade"))
        {
            Debug.Log("Va Cham");
            ProgressBarCircle(10);
            IteamUIManager.instance.AddNade(1);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("gun"))
        {
            Debug.Log("Va Cham");
            ProgressBarCircle(5);
            IteamUIManager.instance.AddGun(1);
            other.gameObject.SetActive(false);
        }

    }
}
