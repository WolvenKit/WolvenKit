using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StaminaPoolListener : gameScriptStatPoolsListener
	{
		private wCHandle<StaminabarWidgetGameController> _staminaBar;

		[Ordinal(0)] 
		[RED("staminaBar")] 
		public wCHandle<StaminabarWidgetGameController> StaminaBar
		{
			get
			{
				if (_staminaBar == null)
				{
					_staminaBar = (wCHandle<StaminabarWidgetGameController>) CR2WTypeManager.Create("whandle:StaminabarWidgetGameController", "staminaBar", cr2w, this);
				}
				return _staminaBar;
			}
			set
			{
				if (_staminaBar == value)
				{
					return;
				}
				_staminaBar = value;
				PropertySet(this);
			}
		}

		public StaminaPoolListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
