Shader "Custom/Grow"
{
	Properties
	{
		_Color("Diffuse Color",Color) = (1,1,1,1)
		_MyEmission("Glow Color",Color) = (0,0,0,0) //色と光の強さを制御するプロパティ
	}

 SubShader{
		Tags { "RenderType" = "Opaque" }
		
		CGPROGRAM
		#pragma surface surf Lambert

		float4 _Color;
	    float4 _MyEmission;

	    struct Input {float2 Dummy;};

	void surf(Input IN, inout SurfaceOutput o) 
	{
		o.Albedo = _Color;
		o.Enission =_MyEmission;
	}
		ENDCG
 }
	FallBack "Diffuse"
}