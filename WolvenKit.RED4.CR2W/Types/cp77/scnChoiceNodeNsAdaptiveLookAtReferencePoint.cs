using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsAdaptiveLookAtReferencePoint : CVariable
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

		public scnChoiceNodeNsAdaptiveLookAtReferencePoint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
