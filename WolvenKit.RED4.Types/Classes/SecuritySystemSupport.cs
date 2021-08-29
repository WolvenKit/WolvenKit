using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystemSupport : redEvent
	{
		private CBool _supportGranted;

		[Ordinal(0)] 
		[RED("supportGranted")] 
		public CBool SupportGranted
		{
			get => GetProperty(ref _supportGranted);
			set => SetProperty(ref _supportGranted, value);
		}
	}
}
