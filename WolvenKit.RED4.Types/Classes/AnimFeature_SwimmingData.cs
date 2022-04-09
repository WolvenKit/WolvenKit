using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_SwimmingData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AnimFeature_SwimmingData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
