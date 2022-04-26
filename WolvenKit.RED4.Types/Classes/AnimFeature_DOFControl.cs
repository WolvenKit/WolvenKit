using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_DOFControl : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("dofIntensity")] 
		public CFloat DofIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("dofNearBlur")] 
		public CFloat DofNearBlur
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("dofNearFocus")] 
		public CFloat DofNearFocus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("dofFarBlur")] 
		public CFloat DofFarBlur
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("dofFarFocus")] 
		public CFloat DofFarFocus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("dofBlendInTime")] 
		public CFloat DofBlendInTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("dofBlendOutTime")] 
		public CFloat DofBlendOutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_DOFControl()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
