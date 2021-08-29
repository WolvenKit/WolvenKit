using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimStateTransitionCondition_CompositeSimultaneous : animIAnimStateTransitionCondition
	{
		private CArray<CHandle<animIAnimStateTransitionCondition>> _conditions;

		[Ordinal(0)] 
		[RED("conditions")] 
		public CArray<CHandle<animIAnimStateTransitionCondition>> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}
	}
}
