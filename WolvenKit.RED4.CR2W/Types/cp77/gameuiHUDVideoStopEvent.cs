using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDVideoStopEvent : CVariable
	{
		private CUInt64 _videoPathHash;
		private CBool _isSkip;

		[Ordinal(0)] 
		[RED("videoPathHash")] 
		public CUInt64 VideoPathHash
		{
			get => GetProperty(ref _videoPathHash);
			set => SetProperty(ref _videoPathHash, value);
		}

		[Ordinal(1)] 
		[RED("isSkip")] 
		public CBool IsSkip
		{
			get => GetProperty(ref _isSkip);
			set => SetProperty(ref _isSkip, value);
		}

		public gameuiHUDVideoStopEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
