using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponShootPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("howManyAttacks")] 
		public CInt32 HowManyAttacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public WeaponShootPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
