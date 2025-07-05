using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetAnimsetOverrideForPassengerNPC : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("IsNPCMounted")] 
		public CHandle<AIArgumentMapping> IsNPCMounted
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public SetAnimsetOverrideForPassengerNPC()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
