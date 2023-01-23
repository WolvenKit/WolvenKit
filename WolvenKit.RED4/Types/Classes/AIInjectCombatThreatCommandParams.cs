using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIInjectCombatThreatCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] 
		[RED("targetNodeRef")] 
		public NodeRef TargetNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("targetPuppetRef")] 
		public gameEntityReference TargetPuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("dontForceHostileAttitude")] 
		public CBool DontForceHostileAttitude
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("isPersistent")] 
		public CBool IsPersistent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIInjectCombatThreatCommandParams()
		{
			TargetPuppetRef = new() { Names = new() };
			Duration = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
