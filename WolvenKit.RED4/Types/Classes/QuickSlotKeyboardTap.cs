using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickSlotKeyboardTap : redEvent
	{
		[Ordinal(0)] 
		[RED("keyIndex")] 
		public CInt32 KeyIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public QuickSlotKeyboardTap()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
