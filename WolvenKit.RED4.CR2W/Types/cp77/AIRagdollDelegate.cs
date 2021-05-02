using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIRagdollDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private wCHandle<gameObject> _ragdollInstigator;
		private Vector4 _closestNavmeshPoint;
		private CBool _ragdollOutOfNavmesh;
		private CBool _isUnderwater;
		private CBool _poseAllowsRecovery;

		[Ordinal(0)] 
		[RED("ragdollInstigator")] 
		public wCHandle<gameObject> RagdollInstigator
		{
			get => GetProperty(ref _ragdollInstigator);
			set => SetProperty(ref _ragdollInstigator, value);
		}

		[Ordinal(1)] 
		[RED("closestNavmeshPoint")] 
		public Vector4 ClosestNavmeshPoint
		{
			get => GetProperty(ref _closestNavmeshPoint);
			set => SetProperty(ref _closestNavmeshPoint, value);
		}

		[Ordinal(2)] 
		[RED("ragdollOutOfNavmesh")] 
		public CBool RagdollOutOfNavmesh
		{
			get => GetProperty(ref _ragdollOutOfNavmesh);
			set => SetProperty(ref _ragdollOutOfNavmesh, value);
		}

		[Ordinal(3)] 
		[RED("isUnderwater")] 
		public CBool IsUnderwater
		{
			get => GetProperty(ref _isUnderwater);
			set => SetProperty(ref _isUnderwater, value);
		}

		[Ordinal(4)] 
		[RED("poseAllowsRecovery")] 
		public CBool PoseAllowsRecovery
		{
			get => GetProperty(ref _poseAllowsRecovery);
			set => SetProperty(ref _poseAllowsRecovery, value);
		}

		public AIRagdollDelegate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
