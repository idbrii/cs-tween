// Easing functions for smooth movement over time.
//
// All functions take a single argument: p for progress.

// If you want to use these outside of Unity, you could try System.Math, but it
// deals in doubles so you may need a wrapper or alternative implementation.
//~ using Mathf = System.Math;
using Mathf = UnityEngine.Mathf;

namespace idbrii.MoreMath
{
    // See visualizations of these functions on https://easings.net/
    public static class Easing
    {

        // These functions were generated by gen_easing.lua.

        public static float QuartIn(float p)
        {
            return p * p * p * p;
        }
        public static float QuartOut(float p)
        {
            p = 1f - p;
            return 1f - (QuartIn(p));
        }
        public static float QuartInOut(float p)
        {
            p = p * 2;
            if (p < 1f) {
                return 0.5f * (QuartIn(p));
            }
            else {
                p = 2f - p;
                return 0.5f * (1f - (QuartIn(p))) + 0.5f;
            }
        }

        public static float QuintIn(float p)
        {
            return p * p * p * p * p;
        }
        public static float QuintOut(float p)
        {
            p = 1f - p;
            return 1f - (QuintIn(p));
        }
        public static float QuintInOut(float p)
        {
            p = p * 2;
            if (p < 1f) {
                return 0.5f * (QuintIn(p));
            }
            else {
                p = 2f - p;
                return 0.5f * (1f - (QuintIn(p))) + 0.5f;
            }
        }

        public static float CubicIn(float p)
        {
            return p * p * p;
        }
        public static float CubicOut(float p)
        {
            p = 1f - p;
            return 1f - (CubicIn(p));
        }
        public static float CubicInOut(float p)
        {
            p = p * 2;
            if (p < 1f) {
                return 0.5f * (CubicIn(p));
            }
            else {
                p = 2f - p;
                return 0.5f * (1f - (CubicIn(p))) + 0.5f;
            }
        }

        public static float ElasticIn(float p)
        {
            return -(Mathf.Pow(2, 10 * (p - 1f)) * Mathf.Sin((p - 1.075f) * (Mathf.PI * 2) / 0.3f));
        }
        public static float ElasticOut(float p)
        {
            p = 1f - p;
            return 1f - (ElasticIn(p));
        }
        public static float ElasticInOut(float p)
        {
            p = p * 2;
            if (p < 1f) {
                return 0.5f * (ElasticIn(p));
            }
            else {
                p = 2f - p;
                return 0.5f * (1f - (ElasticIn(p))) + 0.5f;
            }
        }

        public static float BackIn(float p)
        {
            return p * p * (2.7f * p - 1.7f);
        }
        public static float BackOut(float p)
        {
            p = 1f - p;
            return 1f - (BackIn(p));
        }
        public static float BackInOut(float p)
        {
            p = p * 2;
            if (p < 1f) {
                return 0.5f * (BackIn(p));
            }
            else {
                p = 2f - p;
                return 0.5f * (1f - (BackIn(p))) + 0.5f;
            }
        }

        public static float SineIn(float p)
        {
            return -Mathf.Cos(p * (Mathf.PI * 0.5f)) + 1f;
        }
        public static float SineOut(float p)
        {
            p = 1f - p;
            return 1f - (SineIn(p));
        }
        public static float SineInOut(float p)
        {
            p = p * 2;
            if (p < 1f) {
                return 0.5f * (SineIn(p));
            }
            else {
                p = 2f - p;
                return 0.5f * (1f - (SineIn(p))) + 0.5f;
            }
        }

        public static float ExpoIn(float p)
        {
            return Mathf.Pow(2, (10 * (p - 1f)));
        }
        public static float ExpoOut(float p)
        {
            p = 1f - p;
            return 1f - (ExpoIn(p));
        }
        public static float ExpoInOut(float p)
        {
            p = p * 2;
            if (p < 1f) {
                return 0.5f * (ExpoIn(p));
            }
            else {
                p = 2f - p;
                return 0.5f * (1f - (ExpoIn(p))) + 0.5f;
            }
        }

        public static float QuadIn(float p)
        {
            return p * p;
        }
        public static float QuadOut(float p)
        {
            p = 1f - p;
            return 1f - (QuadIn(p));
        }
        public static float QuadInOut(float p)
        {
            p = p * 2;
            if (p < 1f) {
                return 0.5f * (QuadIn(p));
            }
            else {
                p = 2f - p;
                return 0.5f * (1f - (QuadIn(p))) + 0.5f;
            }
        }

        public static float CircIn(float p)
        {
            return -(Mathf.Sqrt(1f - (p * p)) - 1f);
        }
        public static float CircOut(float p)
        {
            p = 1f - p;
            return 1f - (CircIn(p));
        }
        public static float CircInOut(float p)
        {
            p = p * 2;
            if (p < 1f) {
                return 0.5f * (CircIn(p));
            }
            else {
                p = 2f - p;
                return 0.5f * (1f - (CircIn(p))) + 0.5f;
            }
        }

    }
}
