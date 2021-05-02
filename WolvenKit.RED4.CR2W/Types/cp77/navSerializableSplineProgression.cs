using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navSerializableSplineProgression : CVariable
	{
		private CUInt32 _sectionIdx;
		private CFloat _alpha;

		[Ordinal(0)] 
		[RED("sectionIdx")] 
		public CUInt32 SectionIdx
		{
			get => GetProperty(ref _sectionIdx);
			set => SetProperty(ref _sectionIdx, value);
		}

		[Ordinal(1)] 
		[RED("alpha")] 
		public CFloat Alpha
		{
			get => GetProperty(ref _alpha);
			set => SetProperty(ref _alpha, value);
		}

		public navSerializableSplineProgression(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
