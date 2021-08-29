using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorRandomConditionDefinition : AIbehaviorConditionDefinition
	{
		private CFloat _chance;

		[Ordinal(1)] 
		[RED("chance")] 
		public CFloat Chance
		{
			get => GetProperty(ref _chance);
			set => SetProperty(ref _chance, value);
		}
	}
}
