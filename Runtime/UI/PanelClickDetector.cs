using System;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using FujiUnityUtilities.Extensions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace FujiUnityUtilities.UI {
    public class PanelClickDetector : MonoBehaviour, IPointerClickHandler {
        public event Action onClickDetected;

        public Image image;
        public Canvas canvas;
        public float opacity;

        private float _fadeInDuration, _fadeOutDuration;
        private Ease _fadeInEase, _fadeOutEase;

        public PanelClickDetector SetFadeIn(float duration, Ease ease = Ease.OutQuad) {
            _fadeInDuration = duration;
            _fadeInEase = ease;

            return this;
        }
        
        public PanelClickDetector SetFadeOut(float duration, Ease ease = Ease.OutQuad) {
            _fadeOutDuration = duration;
            _fadeOutEase = ease;

            return this;
        }

        public PanelClickDetector SetFade(float opacity, float duration, Ease ease = Ease.OutQuad) {
            this.opacity = opacity;
            SetFadeIn(duration, ease);
            SetFadeOut(duration, ease);

            return this;
        }

        public PanelClickDetector SetOpacity(float opacity) {
            this.opacity = opacity;

            return this;
        }

        public PanelClickDetector OverrideSortingLayer(string layerName = null, int sortingOrder = 0) {
            canvas.overrideSorting = true;
            if (layerName != null) {
                canvas.sortingLayerName = layerName;
            }
            canvas.sortingOrder = sortingOrder;

            return this;
        }

        public void Dispose() {
            DisposeAsync().Forget();
        }

        public async UniTask DisposeAsync() {
            if (_fadeOutDuration > 0) {
                await FadeOut();
            }
            Destroy(gameObject);
        }

        public void OnPointerClick(PointerEventData eventData) {
            onClickDetected?.Invoke();
            onClickDetected = null;
            DisposeAsync().Forget();
        }

        public static PanelClickDetector Create(Transform parent, Action callback = null) {
            var go = new GameObject("Panel Click Detector");
            
            var panel = go.AddComponent<PanelClickDetector>();
            if (callback != null) {
                panel.onClickDetected += callback;
            }

            panel.canvas = go.AddComponent<Canvas>();
            go.AddComponent<GraphicRaycaster>();
            
            panel.image = go.AddComponent<Image>();
            panel.image.color = Color.black;
            var tr = go.transform.AsRectTransform();
            
            tr.SetParent(parent, false);
            tr.FillParent();

            return panel;
        }

        private async UniTask FadeIn() {
            if (_fadeInDuration > 0) {
                await image.DOFade(opacity, _fadeInDuration)
                    .From(0)
                    .SetEase(_fadeInEase);
            }
        }

        private async UniTask FadeOut() {
            image.raycastTarget = false;
            if (_fadeOutDuration > 0) {
                await image.DOFade(0, _fadeOutDuration)
                    .SetEase(_fadeOutEase);
            }
        }

        private void Start() {
            FadeIn().Forget();
        }
    }
}