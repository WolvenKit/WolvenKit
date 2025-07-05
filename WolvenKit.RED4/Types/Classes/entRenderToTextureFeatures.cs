using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entRenderToTextureFeatures : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("renderDecals")] 
		public CBool RenderDecals
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("renderParticles")] 
		public CBool RenderParticles
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("renderForwardNoTXAA")] 
		public CBool RenderForwardNoTXAA
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("antiAliasing")] 
		public CEnum<entRenderToTextureFeaturesPlatform> AntiAliasing
		{
			get => GetPropertyValue<CEnum<entRenderToTextureFeaturesPlatform>>();
			set => SetPropertyValue<CEnum<entRenderToTextureFeaturesPlatform>>(value);
		}

		[Ordinal(4)] 
		[RED("contactShadows")] 
		public CBool ContactShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("localShadows")] 
		public CBool LocalShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("SSAO")] 
		public CEnum<entRenderToTextureFeaturesPlatform> SSAO
		{
			get => GetPropertyValue<CEnum<entRenderToTextureFeaturesPlatform>>();
			set => SetPropertyValue<CEnum<entRenderToTextureFeaturesPlatform>>(value);
		}

		[Ordinal(7)] 
		[RED("reflections")] 
		public CEnum<entRenderToTextureFeaturesPlatform> Reflections
		{
			get => GetPropertyValue<CEnum<entRenderToTextureFeaturesPlatform>>();
			set => SetPropertyValue<CEnum<entRenderToTextureFeaturesPlatform>>(value);
		}

		public entRenderToTextureFeatures()
		{
			RenderDecals = true;
			RenderParticles = true;
			LocalShadows = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
