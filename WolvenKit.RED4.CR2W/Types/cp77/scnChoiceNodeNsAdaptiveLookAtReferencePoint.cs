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
			get
			{
				if (_referencePoint == null)
				{
					_referencePoint = (scnReferencePointId) CR2WTypeManager.Create("scnReferencePointId", "referencePoint", cr2w, this);
				}
				return _referencePoint;
			}
			set
			{
				if (_referencePoint == value)
				{
					return;
				}
				_referencePoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("constantWeight")] 
		public CFloat ConstantWeight
		{
			get
			{
				if (_constantWeight == null)
				{
					_constantWeight = (CFloat) CR2WTypeManager.Create("Float", "constantWeight", cr2w, this);
				}
				return _constantWeight;
			}
			set
			{
				if (_constantWeight == value)
				{
					return;
				}
				_constantWeight = value;
				PropertySet(this);
			}
		}

		public scnChoiceNodeNsAdaptiveLookAtReferencePoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
