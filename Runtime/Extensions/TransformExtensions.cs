using UnityEngine;

namespace FujiUnityUtilities.Extensions {
    public static class TransformExtensions {
        public static Transform Clear(this Transform transform)
        {
            foreach (Transform child in transform) {
                if (Application.isPlaying) {
                    GameObject.Destroy(child.gameObject);
                } else {
                    GameObject.DestroyImmediate(child.gameObject);
                }
            }
            return transform;
        }

        public static RectTransform AsRectTransform(this Transform transform) {
            return (RectTransform)transform;
        }
    }
}