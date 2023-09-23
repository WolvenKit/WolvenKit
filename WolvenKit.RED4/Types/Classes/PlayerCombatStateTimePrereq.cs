using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerCombatStateTimePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("minTime")] 
		public CFloat MinTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("maxTime")] 
		public CFloat MaxTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public PlayerCombatStateTimePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
