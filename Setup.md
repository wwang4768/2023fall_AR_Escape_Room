### Setting up Unity Project for AR
1. Create a 3D URP project
2. Assets > Import Package > Custom Package > (Vuforia.pkg file from HW4)
3. Window > Vuforia Configuration > (Add App License Key)
  - https://developer.vuforia.com/vui/develop/licenses
  - Prepare any other marker files as needed.
4. Game Object > Vuforia Engine > ARCamera
5. Delete Main Camera
6. GameObject > Vuforia Engine > ImageTarget
7. All objects attached to the ImageTarget should be children of the imageTarget
8. When building, File > Build Settings > IOS (Switch Platform)
9. File > Build Settings > Player Settings (which is on the bottom left) > Target minimum iOS Version 14.0

- To move to iPhone. Build, then open the .xcode file. Run the .xcode file to download to iPhone (check to make sure you have the right IOSDeviceSupport. etc.)