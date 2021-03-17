using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputState : CVariable
	{
		private CUInt32 _frameId;

		[Ordinal(0)] 
		[RED("frameId")] 
		public CUInt32 FrameId
		{
			get => GetProperty(ref _frameId);
			set => SetProperty(ref _frameId, value);
		}

		public gameMuppetInputState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
