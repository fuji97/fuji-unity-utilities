using UnityEngine;

namespace FujiUnityUtilities.Extensions {
    public static class RectTransformExtensions {
        public static RectTransform FillParent(this RectTransform rectTransform) {
            rectTransform.anchorMin = new Vector2(0, 0);
            rectTransform.anchorMax = new Vector2(1, 1);
            rectTransform.pivot = new Vector2(.5f, .5f);
            rectTransform.sizeDelta = new Vector2(0, 0);
            rectTransform.anchoredPosition = new Vector2(0, 0);

            return rectTransform;
        }
    }
}