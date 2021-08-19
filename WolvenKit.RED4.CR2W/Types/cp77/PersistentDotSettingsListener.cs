using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PersistentDotSettingsListener : userSettingsVarListener
	{
		private wCHandle<CrosshairGameControllerPersistentDot> _ctrl;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public wCHandle<CrosshairGameControllerPersistentDot> Ctrl
		{
			get => GetProperty(ref _ctrl);
			set => SetProperty(ref _ctrl, value);
		}

		public PersistentDotSettingsListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
