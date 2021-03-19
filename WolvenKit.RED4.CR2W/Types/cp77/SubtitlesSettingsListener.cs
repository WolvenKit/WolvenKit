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
			get => GetProperty(ref _ctrl);
			set => SetProperty(ref _ctrl, value);
		}

		public SubtitlesSettingsListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
