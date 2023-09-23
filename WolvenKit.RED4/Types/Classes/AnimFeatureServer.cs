using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeatureServer : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("coverState")] 
		public CInt32 CoverState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("serverState")] 
		public CInt32 ServerState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AnimFeatureServer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
