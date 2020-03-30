using UnityEditor;
using UnityEngine;

public class Editor
{
    [MenuItem("Scenes Manager/Save Scene")]
    static void SaveScene()
    {
        string path = EditorUtility.SaveFilePanel("Save Scene", Application.dataPath, "Scene", "xml");
        if (path.Length != 0)
        {
            SaveAndLoadXML.SaveToXML(path);
        }
    }

    [MenuItem("Scenes Manager/Load Scene")]
    static void LoadScene()
    {
        string path = EditorUtility.OpenFilePanel("Load Scene", Application.dataPath, "xml");
        if (path.Length != 0)
        {
            SaveAndLoadXML.LoadFromXML(path);
        }

    }


}
