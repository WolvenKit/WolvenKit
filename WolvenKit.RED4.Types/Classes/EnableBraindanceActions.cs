using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EnableBraindanceActions : redEvent
	{
		private SBraindanceInputMask _actionMask;

		[Ordinal(0)] 
		[RED("actionMask")] 
		public SBraindanceInputMask ActionMask
		{
			get => GetProperty(ref _actionMask);
			set => SetProperty(ref _actionMask, value);
		}
	}
}
