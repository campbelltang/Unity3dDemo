using UnityEditor;
using System.Collections;
using System.IO;
using System;

public class AutoBuild
{

  public static void PerformBuild() {
    ArrayList sceneFiles = new ArrayList();

    foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes) {
      sceneFiles.Add(scene.path);
    }

    string[] scenes = (string[])sceneFiles.ToArray(typeof(string));

    string outdir = "/Users/Shared/workspace/Unity3dDemo/Unity3dDemo2ios";

    BuildPipeline.BuildPlayer(scenes, outdir, BuildTarget.iPhone, BuildOptions.None);

    EditorApplication.Exit(0);
  }

  public static void PerformDemoBuild() {
    PlayerSettings.productName = "Unity3dDemo";
    PlayerSettings.bundleIdentifier = "com.happylatte.Unidy3dDemo";
    EditorUserBuildSettings.development = true;
    PerformBuild();
  }
}
