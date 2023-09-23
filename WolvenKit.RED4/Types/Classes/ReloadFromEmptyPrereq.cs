using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReloadFromEmptyPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("minAmountOfAmmoReloaded")] 
		public CInt32 MinAmountOfAmmoReloaded
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ReloadFromEmptyPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
