using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FeedEvent : redEvent
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

		public FeedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
