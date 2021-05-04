using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entUncontrolledMovementStartEvent : redEvent
	{
		private CFloat _ragdollNoGroundThreshold;
		private CBool _ragdollOnCollision;

		[Ordinal(0)] 
		[RED("ragdollNoGroundThreshold")] 
		public CFloat RagdollNoGroundThreshold
		{
			get => GetProperty(ref _ragdollNoGroundThreshold);
			set => SetProperty(ref _ragdollNoGroundThreshold, value);
		}

		[Ordinal(1)] 
		[RED("ragdollOnCollision")] 
		public CBool RagdollOnCollision
		{
			get => GetProperty(ref _ragdollOnCollision);
			set => SetProperty(ref _ragdollOnCollision, value);
		}

		public entUncontrolledMovementStartEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
