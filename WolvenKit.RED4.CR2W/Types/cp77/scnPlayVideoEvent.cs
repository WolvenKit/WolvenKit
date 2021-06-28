using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayVideoEvent : scnSceneEvent
	{
		private CString _videoPath;
		private CBool _isPhoneCall;
		private CBool _forceFrameRate;

		[Ordinal(6)] 
		[RED("videoPath")] 
		public CString VideoPath
		{
			get => GetProperty(ref _videoPath);
			set => SetProperty(ref _videoPath, value);
		}

		[Ordinal(7)] 
		[RED("isPhoneCall")] 
		public CBool IsPhoneCall
		{
			get => GetProperty(ref _isPhoneCall);
			set => SetProperty(ref _isPhoneCall, value);
		}

		[Ordinal(8)] 
		[RED("forceFrameRate")] 
		public CBool ForceFrameRate
		{
			get => GetProperty(ref _forceFrameRate);
			set => SetProperty(ref _forceFrameRate, value);
		}

		public scnPlayVideoEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
