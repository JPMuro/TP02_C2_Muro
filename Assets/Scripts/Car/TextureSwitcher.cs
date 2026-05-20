using UnityEngine;

[ExecuteAlways]
public class TextureSwitcher : MonoBehaviour
{
    public enum TextureType
    {
        Default,
        Red,
        Blue,
        Damaged
    }

    public Renderer targetRenderer;

    public Texture defaultTexture;
    public Texture damagedTexture;

    public TextureType selectedTexture;

    private Material runtimeMaterial;

    void Awake()
    {
        SetupMaterial();
    }

    void OnValidate()
    {
        SetupMaterial();

        if (runtimeMaterial == null)
            return;

        Texture tex = defaultTexture;

        switch (selectedTexture)
        {
            case TextureType.Default:
                tex = defaultTexture;
                break;

            case TextureType.Damaged:
                tex = damagedTexture;
                break;
        }

        runtimeMaterial.mainTexture = tex;
    }

    void SetupMaterial()
    {
        if (targetRenderer == null)
            return;

        if (runtimeMaterial == null)
        {
            runtimeMaterial = new Material(targetRenderer.sharedMaterial);
            targetRenderer.sharedMaterial = runtimeMaterial;
        }
    }
}