using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatTimeDependentSinus : animAnimNode_FloatValue
	{
		private CFloat _min;
		private CFloat _max;
		private CFloat _frequencyFactor;
		private CFloat _phaseFactor;

		[Ordinal(11)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(12)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}

		[Ordinal(13)] 
		[RED("frequencyFactor")] 
		public CFloat FrequencyFactor
		{
			get => GetProperty(ref _frequencyFactor);
			set => SetProperty(ref _frequencyFactor, value);
		}

		[Ordinal(14)] 
		[RED("phaseFactor")] 
		public CFloat PhaseFactor
		{
			get => GetProperty(ref _phaseFactor);
			set => SetProperty(ref _phaseFactor, value);
		}

		public animAnimNode_FloatTimeDependentSinus(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
