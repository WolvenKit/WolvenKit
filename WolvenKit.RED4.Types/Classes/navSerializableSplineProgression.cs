using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class navSerializableSplineProgression : RedBaseClass
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
	}
}
