# Unity 2019 AssetBundle issue test project

AssetBundle with 1 video clips CAN NOT play on Unity 2019.

(Working well on Unity 2018)

This test project contains below assetbundles.

bundle builded in Unity 2018.4

- video_01_2018
  - just one video clip
- video_02_2018
  - 2 video clips
- video_03_2018
  - 3 video clips
- video_04_2018
  - one video clip with dummy bytes files.

bundle builded in Unity 2019.1

- video_01_2019
   - just one video clip
- video_02_2019
   - 2 video clips
- video_03_2019
   - 3 video clips
- video_04_2019
   - one video clip with dummy bytes files.

In Unity 2019, VideoPlayer can't play VideoClip in Assetbundle that contains 1 video clip.

This project linked in Unity forum
https://forum.unity.com/threads/assetbundle-with-single-videoclip-is-not-working-and-occur-error.726875/
