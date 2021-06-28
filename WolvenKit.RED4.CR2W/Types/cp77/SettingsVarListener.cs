using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsVarListener : userSettingsVarListener
	{
		private wCHandle<SettingsMainGameController> _ctrl;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public wCHandle<SettingsMainGameController> Ctrl
		{
			get => GetProperty(ref _ctrl);
			set => SetProperty(ref _ctrl, value);
		}

		public SettingsVarListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
