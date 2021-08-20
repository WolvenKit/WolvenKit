using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITargetTrackerComponent : gameComponent
	{
		private CBool _triggersCombat;

		[Ordinal(4)] 
		[RED("TriggersCombat")] 
		public CBool TriggersCombat
		{
			get => GetProperty(ref _triggersCombat);
			set => SetProperty(ref _triggersCombat, value);
		}

		public AITargetTrackerComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
