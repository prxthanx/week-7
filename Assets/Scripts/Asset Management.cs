using System.Collections;
using System.Collections.Generic;
using UnityEngine;
void CompressTextures()
{
    Texture2D[] textures = Resources.LoadAll<Texture2D>("Textures");
    foreach (Texture2D texture in textures)
    {
        texture.Compress(true); // Compress the texture
    }
}
