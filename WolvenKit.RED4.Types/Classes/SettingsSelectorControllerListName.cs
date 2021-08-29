using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SettingsSelectorControllerListName : SettingsSelectorControllerList
	{
		private CWeakHandle<userSettingsVarListName> _realValue;
		private CInt32 _currentIndex;

		[Ordinal(20)] 
		[RED("realValue")] 
		public CWeakHandle<userSettingsVarListName> RealValue
		{
			get => GetProperty(ref _realValue);
			set => SetProperty(ref _realValue, value);
		}

		[Ordinal(21)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get => GetProperty(ref _currentIndex);
			set => SetProperty(ref _currentIndex, value);
		}
	}
}
