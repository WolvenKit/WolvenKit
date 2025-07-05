using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCyberspacePixelsortEffectParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("fullscreen")] 
		public CBool Fullscreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("vfx")] 
		public CBool Vfx
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("initialDatamosh")] 
		public CFloat InitialDatamosh
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("targetDatamosh")] 
		public CFloat TargetDatamosh
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("initialIntensity")] 
		public CFloat InitialIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("targetIntensity")] 
		public CFloat TargetIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("timeBlend")] 
		public CFloat TimeBlend
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameCyberspacePixelsortEffectParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
