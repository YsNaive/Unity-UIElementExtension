using UnityEngine;
using UnityEngine.UIElements;

namespace NaiveAPI_UI
{
    [System.Serializable]
    public class ISText
    {
        public Font Font;
        public FontStyle FontStyle;
        public int FontSize = 14;
        public Color Color = Color.black;
        public TextAnchor Align = TextAnchor.MiddleCenter;
        public Wrap Wrap;
    }
}
