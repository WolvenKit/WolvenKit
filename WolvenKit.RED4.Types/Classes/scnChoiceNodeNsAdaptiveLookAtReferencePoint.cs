using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnChoiceNodeNsAdaptiveLookAtReferencePoint : RedBaseClass
	{
		private scnReferencePointId _referencePoint;
		private CFloat _constantWeight;

		[Ordinal(0)] 
		[RED("referencePoint")] 
		public scnReferencePointId ReferencePoint
		{
			get => GetProperty(ref _referencePoint);
			set => SetProperty(ref _referencePoint, value);
		}

		[Ordinal(1)] 
		[RED("constantWeight")] 
		public CFloat ConstantWeight
		{
			get => GetProperty(ref _constantWeight);
			set => SetProperty(ref _constantWeight, value);
		}
	}
}
