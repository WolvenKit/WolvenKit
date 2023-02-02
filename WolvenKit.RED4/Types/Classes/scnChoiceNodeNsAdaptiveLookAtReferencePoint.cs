using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChoiceNodeNsAdaptiveLookAtReferencePoint : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("referencePoint")] 
		public scnReferencePointId ReferencePoint
		{
			get => GetPropertyValue<scnReferencePointId>();
			set => SetPropertyValue<scnReferencePointId>(value);
		}

		[Ordinal(1)] 
		[RED("constantWeight")] 
		public CFloat ConstantWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public scnChoiceNodeNsAdaptiveLookAtReferencePoint()
		{
			ReferencePoint = new() { Id = 4294967295 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
