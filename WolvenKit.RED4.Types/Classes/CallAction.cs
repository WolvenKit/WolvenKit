using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CallAction : redEvent
	{
		private CEnum<QuickSlotActionType> _calledAction;

		[Ordinal(0)] 
		[RED("calledAction")] 
		public CEnum<QuickSlotActionType> CalledAction
		{
			get => GetProperty(ref _calledAction);
			set => SetProperty(ref _calledAction, value);
		}
	}
}
