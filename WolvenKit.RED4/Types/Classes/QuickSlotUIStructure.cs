using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickSlotUIStructure : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ItemIndex")] 
		public CInt32 ItemIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("OperationResult")] 
		public CBool OperationResult
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuickSlotUIStructure()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
