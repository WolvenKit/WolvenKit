using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraSetup : CVariable
	{
		private CBool _canStreamVideo;

		[Ordinal(0)] 
		[RED("canStreamVideo")] 
		public CBool CanStreamVideo
		{
			get => GetProperty(ref _canStreamVideo);
			set => SetProperty(ref _canStreamVideo, value);
		}

		public CameraSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
