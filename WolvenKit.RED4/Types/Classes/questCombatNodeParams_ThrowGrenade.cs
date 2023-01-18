using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCombatNodeParams_ThrowGrenade : questCombatNodeParams
	{
		[Ordinal(0)] 
		[RED("targetOverrideNode")] 
		public NodeRef TargetOverrideNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("targetOverridePuppet")] 
		public gameEntityReference TargetOverridePuppet
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("once")] 
		public CBool Once
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("immediately")] 
		public CBool Immediately
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCombatNodeParams_ThrowGrenade()
		{
			TargetOverridePuppet = new() { Names = new() };
			Duration = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
