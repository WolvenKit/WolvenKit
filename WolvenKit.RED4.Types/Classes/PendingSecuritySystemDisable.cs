using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PendingSecuritySystemDisable : redEvent
	{
		private CBool _isPending;

		[Ordinal(0)] 
		[RED("isPending")] 
		public CBool IsPending
		{
			get => GetProperty(ref _isPending);
			set => SetProperty(ref _isPending, value);
		}
	}
}
