using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIRagdollDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] 
		[RED("ragdollInstigator")] 
		public CWeakHandle<gameObject> RagdollInstigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("closestNavmeshPoint")] 
		public Vector4 ClosestNavmeshPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("ragdollOutOfNavmesh")] 
		public CBool RagdollOutOfNavmesh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isUnderwater")] 
		public CBool IsUnderwater
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("poseAllowsRecovery")] 
		public CBool PoseAllowsRecovery
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIRagdollDelegate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
