using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_PartData : animAnimFeatureMarkUnstable
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_PartData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
