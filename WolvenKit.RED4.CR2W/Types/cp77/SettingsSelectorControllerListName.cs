using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerListName : SettingsSelectorControllerList
	{
		private wCHandle<userSettingsVarListName> _realValue;
		private CInt32 _currentIndex;

		[Ordinal(20)] 
		[RED("realValue")] 
		public wCHandle<userSettingsVarListName> RealValue
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

		public SettingsSelectorControllerListName(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
