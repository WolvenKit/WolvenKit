using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckRagdollOutOfNavmeshTask : StatusEffectTasks
	{
		[Ordinal(0)] 
		[RED("outStatusArgument")] 
		public CHandle<AIArgumentMapping> OutStatusArgument
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("outPositionStatusArgument")] 
		public CHandle<AIArgumentMapping> OutPositionStatusArgument
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("outPositionArgument")] 
		public CHandle<AIArgumentMapping> OutPositionArgument
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public CheckRagdollOutOfNavmeshTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
