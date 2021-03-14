using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BrightnessSettingsVarListener : userSettingsVarListener
	{
		private wCHandle<BrightnessSettingsGameController> _ctrl;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public wCHandle<BrightnessSettingsGameController> Ctrl
		{
			get
			{
				if (_ctrl == null)
				{
					_ctrl = (wCHandle<BrightnessSettingsGameController>) CR2WTypeManager.Create("whandle:BrightnessSettingsGameController", "ctrl", cr2w, this);
				}
				return _ctrl;
			}
			set
			{
				if (_ctrl == value)
				{
					return;
				}
				_ctrl = value;
				PropertySet(this);
			}
		}

		public BrightnessSettingsVarListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
