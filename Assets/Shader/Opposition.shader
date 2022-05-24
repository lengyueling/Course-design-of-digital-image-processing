// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Opposition" {
	Properties
	{
		_MainTex("Base (RGB)", 2D) = "white" {}
	}
		SubShader{
			Pass {
				ZTest Always Cull Off ZWrite Off

				CGPROGRAM

				#include "UnityCG.cginc"

				#pragma vertex vert  
				#pragma fragment frag

				sampler2D _MainTex;



				struct v2f
				{
					float4 pos : SV_POSITION;
					float2 uv:TEXCOORD0;
				};

				v2f vert(appdata_img v) {
					v2f o;
					o.pos = UnityObjectToClipPos(v.vertex);
					o.uv = v.texcoord;
					return o;
				}


				fixed4 frag(v2f i) : SV_Target {
					return fixed4(fixed3(1.0 - tex2D(_MainTex,i.uv).rgb),1.0);
				}

				ENDCG
			}
	}
		FallBack Off
}
