using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HighLevelStateMapping : ChangeHighLevelStateAbstract
	{
		[Ordinal(0)] 
		[RED("stateNameMapping")] 
		public CHandle<AIArgumentMapping> StateNameMapping
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
