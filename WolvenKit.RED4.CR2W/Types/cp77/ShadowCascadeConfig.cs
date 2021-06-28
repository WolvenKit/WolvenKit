using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShadowCascadeConfig : CVariable
	{
		private CFloat _range;
		private CFloat _filterSize;
		private CFloat _blendRange;
		private CFloat _biasOffset;

		[Ordinal(0)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(1)] 
		[RED("filterSize")] 
		public CFloat FilterSize
		{
			get => GetProperty(ref _filterSize);
			set => SetProperty(ref _filterSize, value);
		}

		[Ordinal(2)] 
		[RED("blendRange")] 
		public CFloat BlendRange
		{
			get => GetProperty(ref _blendRange);
			set => SetProperty(ref _blendRange, value);
		}

		[Ordinal(3)] 
		[RED("biasOffset")] 
		public CFloat BiasOffset
		{
			get => GetProperty(ref _biasOffset);
			set => SetProperty(ref _biasOffset, value);
		}

		public ShadowCascadeConfig(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
