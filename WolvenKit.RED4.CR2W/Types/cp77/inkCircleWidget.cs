using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCircleWidget : inkBaseShapeWidget
	{
		private CUInt32 _segmentsNumber;

		[Ordinal(20)] 
		[RED("segmentsNumber")] 
		public CUInt32 SegmentsNumber
		{
			get => GetProperty(ref _segmentsNumber);
			set => SetProperty(ref _segmentsNumber, value);
		}

		public inkCircleWidget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
