using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GetRandomThreat : AIRandomTasks
	{
		[Ordinal(0)] 
		[RED("outThreatArgument")] 
		public CHandle<AIArgumentMapping> OutThreatArgument
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
