using UnityEngine;
using UnityEngine.UIElements;
namespace NaiveAPI_UI
{
    [System.Serializable]
    public class ISRadius
    {
        public ISLength TopLeft = new ISLength();
        public ISLength BottomLeft = new ISLength();
        public ISLength TopRight = new ISLength();
        public ISLength BottomRight = new ISLength();
    }
}