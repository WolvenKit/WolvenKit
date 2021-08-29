using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TCSInputXYAxisEvent : redEvent
	{
		private CBool _isAnyInput;

		[Ordinal(0)] 
		[RED("isAnyInput")] 
		public CBool IsAnyInput
		{
			get => GetProperty(ref _isAnyInput);
			set => SetProperty(ref _isAnyInput, value);
		}
	}
}
