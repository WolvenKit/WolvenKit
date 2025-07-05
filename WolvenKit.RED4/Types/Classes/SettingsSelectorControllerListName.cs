using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingsSelectorControllerListName : SettingsSelectorControllerList
	{
		[Ordinal(21)] 
		[RED("realValue")] 
		public CWeakHandle<userSettingsVarListName> RealValue
		{
			get => GetPropertyValue<CWeakHandle<userSettingsVarListName>>();
			set => SetPropertyValue<CWeakHandle<userSettingsVarListName>>(value);
		}

		[Ordinal(22)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SettingsSelectorControllerListName()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
