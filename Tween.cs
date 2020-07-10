// Coroutines for tweening.

using System.Collections;
using System;
using UnityEngine;


namespace idbrii.MoreMath
{
    // Coroutines to animate Unity objects.
    //
    // Pass MoreMath.Easing functions as fn.
    public static class Tween
    {

        // Avoid use of Lerp because it clamps between [0,1] which breaks
        // curvature of Elastic.

        public static IEnumerator AnimatePos(Transform target, float duration_sec, Func<float,float> fn, Vector3 end)
        {
            Vector3 start = target.position;
            Vector3 delta = end - start;
            float t = 0;
            while (t < duration_sec)
            {
                float p = fn(t / duration_sec);
                var v = p * delta + start;
                target.position = v;
                yield return null;
                t += Time.deltaTime;
            }
            target.position = end;
        }

        public static IEnumerator AnimateRot(Transform target, float duration_sec, Func<float,float> fn, Quaternion end)
        {
            Quaternion start = target.rotation;
            float t = 0;
            while (t < duration_sec)
            {
                float p = fn(t / duration_sec);
                var v = Quaternion.Slerp(start, end, p);
                target.rotation = v;
                yield return null;
                t += Time.deltaTime;
            }
            target.rotation = end;
        }

        public static IEnumerator AnimateNonUniformScale(Transform target, float duration_sec, Func<float,float> fn, Vector3 end)
        {
            Vector3 start = target.position;
            Vector3 delta = end - start;
            float t = 0;
            while (t < duration_sec)
            {
                float p = fn(t / duration_sec);
                var v = p * delta + start;
                // Scale should stay above zero.
                v.x = Math.Max(v.x, 0.001f);
                v.y = Math.Max(v.y, 0.001f);
                v.z = Math.Max(v.z, 0.001f);
                target.localScale = v;
                yield return null;
                t += Time.deltaTime;
            }
            target.localScale = end;
        }

        public static IEnumerator AnimateUniformScale(Transform target, float duration_sec, Func<float,float> fn, float start, float end)
        {
            float t = 0;
            while (t < duration_sec)
            {
                float p = fn(t / duration_sec);
                var v = p * (end - start) + start;
                // Scale should stay above zero.
                v = Mathf.Max(v, 0.001f);
                target.localScale = Vector3.one * v;
                yield return null;
                t += Time.deltaTime;
            }
            target.localScale = Vector3.one * end;
        }

        public static IEnumerator AnimateColor(UnityEngine.UI.Image target, float duration_sec, Func<float,float> fn, Color start, Color end)
        {
            float t = 0;
            while (t < duration_sec)
            {
                float p = fn(t / duration_sec);
                var v = Color.Lerp(start, end, p);
                target.color = v;
                yield return null;
                t += Time.deltaTime;
            }
            target.color = end;
        }

    }
}
