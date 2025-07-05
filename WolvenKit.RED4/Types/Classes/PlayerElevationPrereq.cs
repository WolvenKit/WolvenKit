using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerElevationPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("elevationThreshold")] 
		public CFloat ElevationThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public PlayerElevationPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
