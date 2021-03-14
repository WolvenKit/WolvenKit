using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckPlayerTargetEntityDistanceInterruptConditionParams : CVariable
	{
		private CFloat _distance;
		private CEnum<EComparisonType> _comparisonType;
		private gameEntityReference _targetEntity;

		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CFloat) CR2WTypeManager.Create("Float", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get
			{
				if (_comparisonType == null)
				{
					_comparisonType = (CEnum<EComparisonType>) CR2WTypeManager.Create("EComparisonType", "comparisonType", cr2w, this);
				}
				return _comparisonType;
			}
			set
			{
				if (_comparisonType == value)
				{
					return;
				}
				_comparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetEntity")] 
		public gameEntityReference TargetEntity
		{
			get
			{
				if (_targetEntity == null)
				{
					_targetEntity = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "targetEntity", cr2w, this);
				}
				return _targetEntity;
			}
			set
			{
				if (_targetEntity == value)
				{
					return;
				}
				_targetEntity = value;
				PropertySet(this);
			}
		}

		public scnCheckPlayerTargetEntityDistanceInterruptConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
