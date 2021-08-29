using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CameraSetup : RedBaseClass
	{
		private CBool _canStreamVideo;

		[Ordinal(0)] 
		[RED("canStreamVideo")] 
		public CBool CanStreamVideo
		{
			get => GetProperty(ref _canStreamVideo);
			set => SetProperty(ref _canStreamVideo, value);
		}
	}
}
