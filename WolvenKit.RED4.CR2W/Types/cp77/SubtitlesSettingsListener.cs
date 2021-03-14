using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SubtitlesSettingsListener : userSettingsVarListener
	{
		private wCHandle<BaseSubtitlesGameController> _ctrl;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public wCHandle<BaseSubtitlesGameController> Ctrl
		{
			get
			{
				if (_ctrl == null)
				{
					_ctrl = (wCHandle<BaseSubtitlesGameController>) CR2WTypeManager.Create("whandle:BaseSubtitlesGameController", "ctrl", cr2w, this);
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

		public SubtitlesSettingsListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
