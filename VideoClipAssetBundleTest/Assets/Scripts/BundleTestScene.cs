using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class BundleTestScene : MonoBehaviour
{
    private VideoPlayer vidPlayer;
    private AssetBundle assetBundle;

    [SerializeField] private bool use2018Bundle = true;

    void Start()
    {
        vidPlayer = GetComponent<VideoPlayer>();
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Play video01 (" + (use2018Bundle ? "2018 bundle" : "2019 bundle")))  BundleTest("video_01", use2018Bundle, "video01");
        if (GUILayout.Button("Play video02 (" + (use2018Bundle ? "2018 bundle" : "2019 bundle")))  BundleTest("video_02", use2018Bundle, "video02");
        if (GUILayout.Button("Play video03 (" + (use2018Bundle ? "2018 bundle" : "2019 bundle")))  BundleTest("video_03", use2018Bundle, "video03");
        if (GUILayout.Button("Play video04 (" + (use2018Bundle ? "2018 bundle" : "2019 bundle")))  BundleTest("video_04", use2018Bundle, "video01");
    }

    private void BundleTest(string bundleName, bool use2018, string vid)
    {
        if (assetBundle != null)
        {
            assetBundle.Unload(true);
            assetBundle = null;
        }

        if (assetBundle == null)
        {
            var path = Application.streamingAssetsPath + "/" + bundleName + (use2018 ? "_2018" : "_2019");

            var temp = System.IO.File.ReadAllBytes(path);
            assetBundle = AssetBundle.LoadFromMemory(temp);
            //assetBundle = AssetBundle.LoadFromFile(path);
        }

        var videoClip = assetBundle.LoadAsset<VideoClip>(vid);
        vidPlayer.clip = videoClip;

        Debug.LogFormat("loaded clip name:{0} origPath:{1}",
            videoClip.name,
            videoClip.originalPath);

        vidPlayer.Play();
    }
}
