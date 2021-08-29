using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HighLevelStateMapping : ChangeHighLevelStateAbstract
	{
		private CHandle<AIArgumentMapping> _stateNameMapping;

		[Ordinal(0)] 
		[RED("stateNameMapping")] 
		public CHandle<AIArgumentMapping> StateNameMapping
		{
			get => GetProperty(ref _stateNameMapping);
			set => SetProperty(ref _stateNameMapping, value);
		}
	}
}
