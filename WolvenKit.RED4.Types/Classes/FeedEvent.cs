using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FeedEvent : redEvent
	{
		private CBool _on;
		private CName _virtualComponentName;
		private entEntityID _cameraID;

		[Ordinal(0)] 
		[RED("On")] 
		public CBool On
		{
			get => GetProperty(ref _on);
			set => SetProperty(ref _on, value);
		}

		[Ordinal(1)] 
		[RED("virtualComponentName")] 
		public CName VirtualComponentName
		{
			get => GetProperty(ref _virtualComponentName);
			set => SetProperty(ref _virtualComponentName, value);
		}

		[Ordinal(2)] 
		[RED("cameraID")] 
		public entEntityID CameraID
		{
			get => GetProperty(ref _cameraID);
			set => SetProperty(ref _cameraID, value);
		}
	}
}
