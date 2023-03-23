using UnityEditor;
using DocumentBuilder;
using UnityEngine;
using UnityEngine.UIElements;
using NaiveAPI_UI;

namespace NaiveAPI_Editor
{
    public class UIElementExtensionDocsMenuItem
    {
        [MenuItem("Tools/NaiveAPI/Document/UIElement Extension")]
        public static void OpenNaiveApiDocs()
        {
            string path = AssetDatabase.GUIDToAssetPath(AssetDatabase.FindAssets
                ($"t:Script {nameof(UIElementExtensionDocsMenuItem)}")[0]);

            path = path.Substring(0, path.LastIndexOf("/")+1) + "Docs/UIElement.asset";
            SODocInformation root = AssetDatabase.LoadAssetAtPath<SODocInformation>(path);
            DocumentBuilderWindow.ShowWindow(root, "UIElement Extension Docs");
            VisualElement VisualElement = new VisualElement();

            VisualElement.style.SetIS_Style(new ISDisplay())
                               .SetIS_Style(new ISPosition())
                               .SetIS_Style(new ISStyle());
        }
    }
}
