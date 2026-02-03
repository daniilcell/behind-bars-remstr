using UnityEngine;
using UnityEditor;
using UnityEngine.Networking;
using System;
using System.Collections;

#if UNITY_EDITOR
public class MeetAndTalkProBenefits : EditorWindow
{

    [MenuItem("Meet and Talk/Benefits of Meet and Talk Pro")]
    public static void ShowWindow()
    {
        EditorWindow window = GetWindow<MeetAndTalkProBenefits>(true, "Benefits of Meet and Talk Pro");

        window.position = new Rect(710, 165, 300, 835);
        window.minSize = new Vector2(300, 835);
        window.maxSize = new Vector2(300, 835);

        window.ShowPopup();
    }

    public void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Features", EditorStyles.boldLabel);
        EditorGUILayout.LabelField("Pro", EditorStyles.centeredGreyMiniLabel, GUILayout.Width(30));
        EditorGUILayout.LabelField("Free", EditorStyles.centeredGreyMiniLabel, GUILayout.Width(30));
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.Separator();

        DrawFree("Start Node", "d_Animation.Play");
        DrawFree("Dialogue Node", "d_UnityEditor.HierarchyWindow");
        DrawFree("Choice Node", "d_TreeEditor.Distribution");
        DrawFree("End Node", "d_winbtn_win_close_a@2x");
        DrawFree("Skip Button", "Animation.NextKey");
        DrawFree("Random Start", "align_horizontally_left_active");
        DrawFree("Localization", "Text Icon");
        DrawFree("Audio in Dialogue", "Profiler.Audio");
        DrawFree("Auto Save", "SaveActive");
        DrawFree("Global Value", "Profiler.GlobalIllumination");
        DrawFree("Dynamic UI Change", "Profiler.GlobalIllumination");

        EditorGUILayout.Space(10);

        DrawPro("Event Node", "d_SceneViewFx");
        DrawPro("Timer Choice Node", "d_preAudioAutoPlayOff");
        DrawPro("Random Node", "d_preAudioLoopOff");
        DrawPro("Comment Node", "d_UnityEditor.ConsoleWindow");
        DrawPro("IF Node", "d_preAudioLoopOff");
        DrawPro("Type Writing Animation", "ClothInspector.PaintValue");
        DrawPro("Custom Inspectors", "UnityEditor.InspectorWindow");
        DrawPro("Start By ID", "TreeEditor.Distribution On");
        DrawPro("Characte Avatar", "HumanTemplate Icon");
        DrawPro("Character Emotions", "Halo Icon");
        DrawPro("Global Value in UI", "Canvas Icon");
        DrawPro("Global Value as Character Name", "Preset.Context");
        DrawPro("Import / Export Text File", "Text Icon");
        DrawPro("One-Click Dialogue Translation", "Text Icon");
        DrawPro("Dialogue Save Option", "Text Icon");
        
        if(GUILayout.Button("Meet and Talk - Pro Version\nAsset Store", GUILayout.Height(62.5f)))
        {
            Application.OpenURL("https://u3d.as/30sy");
        }
    }

    void DrawPro(string Name, string icon)
    {
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField(new GUIContent(Name, EditorGUIUtility.IconContent(icon).image as Texture2D));
        EditorGUILayout.LabelField(EditorGUIUtility.IconContent("winbtn_mac_max_h"), GUILayout.Width(30));   // Yes
        EditorGUILayout.LabelField(EditorGUIUtility.IconContent("winbtn_mac_close_h"), GUILayout.Width(25));     // No
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.Separator();
    }
    void DrawPro(string Name)
    {
        DrawPro(Name, "curvekeyframeselected");
    }

    void DrawFree(string Name, string icon)
    {
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField(new GUIContent(Name, EditorGUIUtility.IconContent(icon).image as Texture2D));
        EditorGUILayout.LabelField(EditorGUIUtility.IconContent("winbtn_mac_max_h"), GUILayout.Width(30));   // Yes
        EditorGUILayout.LabelField(EditorGUIUtility.IconContent("winbtn_mac_max_h"), GUILayout.Width(25));   // Yes
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.Separator();
    }

    void DrawFree(string Name)
    {
        DrawFree(Name, "curvekeyframeselected");
    }
}
#endif