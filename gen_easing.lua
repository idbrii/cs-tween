-- Based on https://github.com/rxi/flux/blob/bb33023/flux.lua
-- Modified to output code and to output it as C#.

local easing = {
  Quad    = "p * p",
  Cubic   = "p * p * p",
  Quart   = "p * p * p * p",
  Quint   = "p * p * p * p * p",
  Expo    = "Mathf.Pow(2, (10 * (p - 1f)))",
  Sine    = "-Mathf.Cos(p * (Mathf.PI * 0.5f)) + 1f",
  Circ    = "-(Mathf.Sqrt(1f - (p * p)) - 1f)",
  Back    = "p * p * (2.7f * p - 1.7f)",
  Elastic = "-(Mathf.Pow(2, 10 * (p - 1f)) * Mathf.Sin((p - 1.075f) * (Mathf.PI * 2) / 0.3f))"
}

local printfunc = function(k, variant, str, expr)
  print ("public static float ".. k .. variant .. "(float p)\n{\n" .. str:gsub("%$e", expr):gsub("%$i", k.."In(p)") .. "}")
end

for k, v in pairs(easing) do
  printfunc(k, "In", "return $e;\n", v)
  printfunc(k, "Out", [[
    p = 1f - p;
    return 1f - ($i);
  ]], v)
  printfunc(k, "InOut", [[
    p = p * 2;
    if (p < 1f) {
      return 0.5f * ($i);
    }
    else {
        p = 2f - p;
        return 0.5f * (1f - ($i)) + 0.5f;
    }
  ]], v)
  print()
end
