using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

[CustomPropertyDrawer(typeof(Item))]
public class ItemDrawerUIE : PropertyDrawer
{
    public override VisualElement CreatePropertyGUI(SerializedProperty property)
    {
        var container = new VisualElement();

        var nameField = new PropertyField(property.FindPropertyRelative("name"));
        var valueField = new PropertyField(property.FindPropertyRelative("value"));
        var rarityField = new PropertyField(property.FindPropertyRelative("rarity"));
        var slotField = new PropertyField(property.FindPropertyRelative("slot"));

        container.Add(nameField);
        container.Add(valueField);
        container.Add(rarityField);
        container.Add(slotField);

        return container;
    }
}
