using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFollowerTakedownCommandParams : questScriptedAICommandParams
	{
		private gameEntityReference _targetRef;
		private CBool _approachBeforeTakedown;
		private CBool _doNotTeleportIfTargetIsVisible;

		[Ordinal(0)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		[Ordinal(1)] 
		[RED("approachBeforeTakedown")] 
		public CBool ApproachBeforeTakedown
		{
			get => GetProperty(ref _approachBeforeTakedown);
			set => SetProperty(ref _approachBeforeTakedown, value);
		}

		[Ordinal(2)] 
		[RED("doNotTeleportIfTargetIsVisible")] 
		public CBool DoNotTeleportIfTargetIsVisible
		{
			get => GetProperty(ref _doNotTeleportIfTargetIsVisible);
			set => SetProperty(ref _doNotTeleportIfTargetIsVisible, value);
		}

		public AIFollowerTakedownCommandParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
