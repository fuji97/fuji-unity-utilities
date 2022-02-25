using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace FujiUnityUtilities.Extensions {
    public static class MonoBehaviourExtensions {
        public static RectTransform RectTransform(this GameObject mb) {
            return (RectTransform) mb.transform;
        }
        public static  void Bubble<T>(this GameObject gameObject, PointerEventData eventData, ExecuteEvents.EventFunction<T> eventFunction) where T : IEventSystemHandler
        {
            var allRaycasted = new List<RaycastResult>();
            EventSystem.current.RaycastAll(eventData, allRaycasted);
            foreach (var raycasted in allRaycasted)
            {
                if (raycasted.gameObject == gameObject)
                {
                    continue;
                }
                ExecuteEvents.Execute(raycasted.gameObject, eventData, eventFunction);
            }
        }

    }
}