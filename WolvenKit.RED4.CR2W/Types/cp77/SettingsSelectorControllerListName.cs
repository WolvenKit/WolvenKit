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
			get
			{
				if (_realValue == null)
				{
					_realValue = (wCHandle<userSettingsVarListName>) CR2WTypeManager.Create("whandle:userSettingsVarListName", "realValue", cr2w, this);
				}
				return _realValue;
			}
			set
			{
				if (_realValue == value)
				{
					return;
				}
				_realValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get
			{
				if (_currentIndex == null)
				{
					_currentIndex = (CInt32) CR2WTypeManager.Create("Int32", "currentIndex", cr2w, this);
				}
				return _currentIndex;
			}
			set
			{
				if (_currentIndex == value)
				{
					return;
				}
				_currentIndex = value;
				PropertySet(this);
			}
		}

		public SettingsSelectorControllerListName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
