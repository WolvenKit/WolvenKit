using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GetCurrentPatrolSpotActionPath : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("outPathArgument")] 
		public CHandle<AIArgumentMapping> OutPathArgument
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
