using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CallAction : redEvent
	{
		[Ordinal(0)] 
		[RED("calledAction")] 
		public CEnum<QuickSlotActionType> CalledAction
		{
			get => GetPropertyValue<CEnum<QuickSlotActionType>>();
			set => SetPropertyValue<CEnum<QuickSlotActionType>>(value);
		}
	}
}
