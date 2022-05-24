using UnityEngine;
using System.Collections;

public class Opposition : PostEffectsBase {

	public Shader oppositionShader;
	private Material oppositionMaterial;
	public Material material {  
		get {
            oppositionMaterial = CheckShaderAndCreateMaterial(oppositionShader, oppositionMaterial);
			return oppositionMaterial;
		}  
	}

	void OnRenderImage(RenderTexture src, RenderTexture dest) {
		if (material != null) {
			Graphics.Blit(src, dest, material);
		} else {
			Graphics.Blit(src, dest);
		}
	}
}
