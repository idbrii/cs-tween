# cs-tween
Easing/interpolation/tween functions in C#. And coroutines for using them with Unity.

I prefer this style of single-argument easing because it's simpler to switch
which function you're using and the functions are simpler to think about.
They're in terms of progress: mapping the input linear progress to an output
nonlinear progress.

# Alternatives

If you prefer multi-argument easing functions (that take a time, initial value, delta, and duration) [see these Easing functions](https://gist.github.com/idbrii/2fc7d0595833850acfb5a0722c1c1fcb).
