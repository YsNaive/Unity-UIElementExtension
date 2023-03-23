using NaiveAPI_UI;
using UnityEngine;
using UnityEngine.UIElements;

namespace NaiveAPI.Sample
{
    public class UIElementSample_InspectorPreview : MonoBehaviour
    {
        public SerializableVisualElement<VisualElement> SerializableVisualElement;

        public ISLength ISLength;
        public ISStyleLength ISStyleLength;

        public ISDisplay ISDisplay;
        public ISPosition ISPosition;
        public ISFlex ISFlex;
        public ISAlign ISAlign;
        public ISSize ISSize;
        public ISMargin ISMargin;
        public ISPadding ISPadding;
        public ISText ISText;
        public ISBackground ISBackground;
        public ISBorder ISBorder;
        public ISRadius ISRadius;
        [Tooltip("You can edit which IS is enable on Inspector in default constructor")]
        public ISStyle EditableStyle;
        [Tooltip("This only enable 'Displey','Position','Size' by 000000100110")]
        public ISStyle UnEditableStyle = new ISStyle(38);
    }
}
