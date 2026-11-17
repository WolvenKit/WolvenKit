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

		[Ordinal(1)] 
		[RED("listenedWeapons")] 
		public CArray<CString> ListenedWeapons
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public ReloadFromEmptyPrereq()
		{
			ListenedWeapons = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
