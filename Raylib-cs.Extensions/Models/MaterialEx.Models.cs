using System.Runtime.InteropServices;

namespace Raylib_cs.Extensions;

public static partial class MaterialEx
{
    // temporary fix for #206 (https://github.com/ChrisDill/Raylib-cs/issues/206) >>>
    [DllImport(Raylib.nativeLibName, CallingConvention = CallingConvention.Cdecl)]
    private static extern CBool IsMaterialReady(Material material);
    // <<<
    
    /// <summary>
    /// Check if a material is ready
    /// </summary>
    /// <param name="material"></param>
    /// <returns></returns>
    public static bool IsReady(this Material material) => IsMaterialReady(material);
    
    /// <summary>
    /// Unload material from GPU memory (VRAM)
    /// </summary>
    /// <param name="material"></param>
    public static void Unload(this Material material) => Raylib.UnloadMaterial(material);
    
    /// <summary>
    /// Set texture for a material map type (MATERIAL_MAP_DIFFUSE, MATERIAL_MAP_SPECULAR...)
    /// </summary>
    /// <param name="material"></param>
    /// <param name="mapType"></param>
    /// <param name="texture"></param>
    public static void SetTexture(this ref Material material, MaterialMapIndex mapType, Texture2D texture)
        => Raylib.SetMaterialTexture(ref material, mapType, texture);
    
}