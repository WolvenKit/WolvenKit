using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseContextEvents : InputContextTransitionEvents
	{
		private CInt32 _slicingFrame;

		[Ordinal(1)] 
		[RED("slicingFrame")] 
		public CInt32 SlicingFrame
		{
			get => GetProperty(ref _slicingFrame);
			set => SetProperty(ref _slicingFrame, value);
		}

		public BaseContextEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
