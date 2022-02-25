using UnityEngine;

namespace FujiUnityUtilities.Extensions {
    public static class CanvasGroupExtensions {
        public static void SetInteractable(this CanvasGroup canvasGroup, bool interactable) {
            canvasGroup.interactable = interactable;
            canvasGroup.blocksRaycasts = interactable;
        }
    }
}