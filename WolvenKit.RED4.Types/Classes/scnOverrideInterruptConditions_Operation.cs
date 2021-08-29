using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnOverrideInterruptConditions_Operation : scnIInterruptManager_Operation
	{
		private CArray<CHandle<scnIInterruptCondition>> _interruptConditions;

		[Ordinal(0)] 
		[RED("interruptConditions")] 
		public CArray<CHandle<scnIInterruptCondition>> InterruptConditions
		{
			get => GetProperty(ref _interruptConditions);
			set => SetProperty(ref _interruptConditions, value);
		}
	}
}
