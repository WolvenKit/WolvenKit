using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICommandQueuePS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("behaviorArgumentList")] 
		public CArray<CHandle<AIArgumentInstancePS>> BehaviorArgumentList
		{
			get => GetPropertyValue<CArray<CHandle<AIArgumentInstancePS>>>();
			set => SetPropertyValue<CArray<CHandle<AIArgumentInstancePS>>>(value);
		}

		[Ordinal(1)] 
		[RED("aiRole")] 
		public CHandle<AIRole> AiRole
		{
			get => GetPropertyValue<CHandle<AIRole>>();
			set => SetPropertyValue<CHandle<AIRole>>(value);
		}

		public AICommandQueuePS()
		{
			BehaviorArgumentList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
