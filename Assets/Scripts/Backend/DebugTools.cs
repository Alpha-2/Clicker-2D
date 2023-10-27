#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class DebugTools : EditorWindow
{

    [MenuItem("Window/Debug Tools")]
    static void Init()
    {
        DebugTools Window = (DebugTools)GetWindow(typeof(DebugTools));
        Window.Show();
    }

    private void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();

        if (GUILayout.Button("Main Menu") && EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
            EditorSceneManager.OpenScene("Assets/Scenes/MainMenu.unity");
        if (GUILayout.Button("Game") && EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
            EditorSceneManager.OpenScene("Assets/Scenes/Game.unity");
        EditorGUILayout.EndHorizontal();
        if (GUILayout.Button("Clear Prefs"))
            PlayerPrefs.DeleteAll();
    }

}
#endif