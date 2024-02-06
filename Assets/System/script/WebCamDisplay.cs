using UnityEngine;
using UnityEngine.UI;

public class WebCamDisplay : MonoBehaviour
{
    public RawImage rawImage;

    void Start()
    {
        // Webカメラデバイスの取得
        WebCamDevice[] devices = WebCamTexture.devices;
        if (devices.Length > 0)
        {
            // WebCamTextureのインスタンスを作成
            WebCamTexture webCamTexture = new WebCamTexture(devices[0].name);

            // RawImageにテクスチャとして設定
            rawImage.texture = webCamTexture;
            rawImage.material.mainTexture = webCamTexture;

            // Webカメラの映像の取得を開始
            webCamTexture.Play();
        }
    }
}
