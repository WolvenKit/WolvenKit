using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetAnyTargetIsLocked : redEvent
	{
		private CBool _wasSeen;

		[Ordinal(0)] 
		[RED("wasSeen")] 
		public CBool WasSeen
		{
			get => GetProperty(ref _wasSeen);
			set => SetProperty(ref _wasSeen, value);
		}
	}
}
