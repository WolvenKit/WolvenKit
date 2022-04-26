using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShardForceSelectionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("selectionIndex")] 
		public CInt32 SelectionIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("hash")] 
		public CInt32 Hash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ShardForceSelectionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
