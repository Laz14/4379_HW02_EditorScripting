using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Inventory))]
public class InventoryEditor : Editor
{
    bool isError = false;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Inventory inventory = (Inventory)target;

        GUILayout.Space(30);

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Add"))
        {
            inventory.AddNew();
        }

        if (GUILayout.Button("Remove Last"))
        {
            inventory.Remove(inventory.items.Count - 1);
        }

        GUILayout.EndHorizontal();

        GUILayout.Space(30);

        if (GUILayout.Button("Click Here For an Error"))
        {
            isError = !isError;
        }

        if (isError)
        {
            EditorGUILayout.HelpBox("Why did you click that?", MessageType.Error);
        }

        GUILayout.Space(30);

        if (GUILayout.Button("Rotate"))
        {
            inventory.transform.Rotate(10, 0, 0);
        }
    }
}