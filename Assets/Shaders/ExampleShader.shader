Shader "Custom/ExampleShader"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0

        //_Hit("Hit", Range(0,1)) = 0.0
        _HitColor("Hit Color", Color) = (1.0,0.5,0.1,1)

        //_Charge("Charge", Range(0,1)) = 0.0
        _ChargeColor("Charge Color", Color) = (0.1,0.5,1.0,1)

        //_Attack("Attack", Range(0,1)) = 0.0
        _AttackColor("Attack Color", Color) = (1.0,0.2,0.0,1)

        //_Health("Health", Range(0,1)) = 1.0
        _HealthColor("Health Color", Color) = (1.0,0.5,0.3,1)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        half _Glossiness;
        half _Metallic;
        fixed4 _Color;

        float _Hit;
        fixed4 _HitColor;

        float _Charge;
        fixed4 _ChargeColor;

        float _Attack;
        fixed4 _AttackColor;

        float _Health;
        fixed4 _HealthColor;

        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            // Albedo comes from a texture tinted by color
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
            o.Albedo = c.rgb;
            // Metallic and smoothness come from slider variables
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = c.a;

            half3 emission = _HitColor.xyz * _Hit;
            emission += _ChargeColor.xyz * _Charge;
            emission += _AttackColor.xyz * _Attack;
            emission += _HealthColor.xyz * ( 1.0 - step( 0.333, _Health) ) * (sin(_Time.y * 20) * 0.5 + 0.5) * 0.25;

            o.Emission = emission;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
