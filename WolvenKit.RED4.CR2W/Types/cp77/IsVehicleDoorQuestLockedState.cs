using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsVehicleDoorQuestLockedState : gamePrereqState
	{
		private CHandle<gameScriptedPrereqPSChangeListenerWrapper> _psListener;

		[Ordinal(0)] 
		[RED("psListener")] 
		public CHandle<gameScriptedPrereqPSChangeListenerWrapper> PsListener
		{
			get => GetProperty(ref _psListener);
			set => SetProperty(ref _psListener, value);
		}

		public IsVehicleDoorQuestLockedState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
