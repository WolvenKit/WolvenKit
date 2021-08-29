using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_FloatInterpolation : animAnimNode_FloatValue
	{
		private CFloat _x1;
		private CFloat _x2;
		private CFloat _y1;
		private CFloat _y2;
		private CEnum<animEAnimGraphMathInterpolation> _interpolationType;
		private animFloatLink _inputNode;

		[Ordinal(11)] 
		[RED("x1")] 
		public CFloat X1
		{
			get => GetProperty(ref _x1);
			set => SetProperty(ref _x1, value);
		}

		[Ordinal(12)] 
		[RED("x2")] 
		public CFloat X2
		{
			get => GetProperty(ref _x2);
			set => SetProperty(ref _x2, value);
		}

		[Ordinal(13)] 
		[RED("y1")] 
		public CFloat Y1
		{
			get => GetProperty(ref _y1);
			set => SetProperty(ref _y1, value);
		}

		[Ordinal(14)] 
		[RED("y2")] 
		public CFloat Y2
		{
			get => GetProperty(ref _y2);
			set => SetProperty(ref _y2, value);
		}

		[Ordinal(15)] 
		[RED("interpolationType")] 
		public CEnum<animEAnimGraphMathInterpolation> InterpolationType
		{
			get => GetProperty(ref _interpolationType);
			set => SetProperty(ref _interpolationType, value);
		}

		[Ordinal(16)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}
	}
}
