using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PingDevice : ActionBool
	{
		private CBool _shouldForward;

		[Ordinal(25)] 
		[RED("shouldForward")] 
		public CBool ShouldForward
		{
			get => GetProperty(ref _shouldForward);
			set => SetProperty(ref _shouldForward, value);
		}
	}
}
