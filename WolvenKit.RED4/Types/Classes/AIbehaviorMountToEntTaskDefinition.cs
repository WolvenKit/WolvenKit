using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorMountToEntTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorMountToEntTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
