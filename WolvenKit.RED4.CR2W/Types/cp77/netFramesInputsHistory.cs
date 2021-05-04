using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netFramesInputsHistory : CVariable
	{
		private CArray<netFrameInputs> _frames;

		[Ordinal(0)] 
		[RED("frames")] 
		public CArray<netFrameInputs> Frames
		{
			get => GetProperty(ref _frames);
			set => SetProperty(ref _frames, value);
		}

		public netFramesInputsHistory(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
