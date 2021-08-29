using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickSlotKeyboardTap : redEvent
	{
		private CInt32 _keyIndex;

		[Ordinal(0)] 
		[RED("keyIndex")] 
		public CInt32 KeyIndex
		{
			get => GetProperty(ref _keyIndex);
			set => SetProperty(ref _keyIndex, value);
		}
	}
}
