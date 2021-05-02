using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemMaterialParameter : effectTrackItem
	{
		private CFloat _scale0;
		private effectEffectParameterEvaluator _customParameter0;
		private CFloat _scale1;
		private effectEffectParameterEvaluator _customParameter1;
		private CFloat _scale2;
		private effectEffectParameterEvaluator _customParameter2;
		private CFloat _scale3;
		private effectEffectParameterEvaluator _customParameter3;

		[Ordinal(3)] 
		[RED("scale0")] 
		public CFloat Scale0
		{
			get => GetProperty(ref _scale0);
			set => SetProperty(ref _scale0, value);
		}

		[Ordinal(4)] 
		[RED("customParameter0")] 
		public effectEffectParameterEvaluator CustomParameter0
		{
			get => GetProperty(ref _customParameter0);
			set => SetProperty(ref _customParameter0, value);
		}

		[Ordinal(5)] 
		[RED("scale1")] 
		public CFloat Scale1
		{
			get => GetProperty(ref _scale1);
			set => SetProperty(ref _scale1, value);
		}

		[Ordinal(6)] 
		[RED("customParameter1")] 
		public effectEffectParameterEvaluator CustomParameter1
		{
			get => GetProperty(ref _customParameter1);
			set => SetProperty(ref _customParameter1, value);
		}

		[Ordinal(7)] 
		[RED("scale2")] 
		public CFloat Scale2
		{
			get => GetProperty(ref _scale2);
			set => SetProperty(ref _scale2, value);
		}

		[Ordinal(8)] 
		[RED("customParameter2")] 
		public effectEffectParameterEvaluator CustomParameter2
		{
			get => GetProperty(ref _customParameter2);
			set => SetProperty(ref _customParameter2, value);
		}

		[Ordinal(9)] 
		[RED("scale3")] 
		public CFloat Scale3
		{
			get => GetProperty(ref _scale3);
			set => SetProperty(ref _scale3, value);
		}

		[Ordinal(10)] 
		[RED("customParameter3")] 
		public effectEffectParameterEvaluator CustomParameter3
		{
			get => GetProperty(ref _customParameter3);
			set => SetProperty(ref _customParameter3, value);
		}

		public effectTrackItemMaterialParameter(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
