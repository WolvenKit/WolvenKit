using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCAttitudeTowardsPlayerPrereqState : gamePrereqState
	{
		private CHandle<gameScriptedPrereqAttitudeListenerWrapper> _attitudeListener;

		[Ordinal(0)] 
		[RED("attitudeListener")] 
		public CHandle<gameScriptedPrereqAttitudeListenerWrapper> AttitudeListener
		{
			get => GetProperty(ref _attitudeListener);
			set => SetProperty(ref _attitudeListener, value);
		}

		public NPCAttitudeTowardsPlayerPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
