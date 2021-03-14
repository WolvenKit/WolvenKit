using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_FloatFeature : animIAnimStateTransitionCondition
	{
		private CFloat _compareValue;
		private CName _featureName;
		private CName _featurePropertyName;
		private CEnum<animCompareFunc> _compareFunc;

		[Ordinal(0)] 
		[RED("compareValue")] 
		public CFloat CompareValue
		{
			get
			{
				if (_compareValue == null)
				{
					_compareValue = (CFloat) CR2WTypeManager.Create("Float", "compareValue", cr2w, this);
				}
				return _compareValue;
			}
			set
			{
				if (_compareValue == value)
				{
					return;
				}
				_compareValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("featureName")] 
		public CName FeatureName
		{
			get
			{
				if (_featureName == null)
				{
					_featureName = (CName) CR2WTypeManager.Create("CName", "featureName", cr2w, this);
				}
				return _featureName;
			}
			set
			{
				if (_featureName == value)
				{
					return;
				}
				_featureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("featurePropertyName")] 
		public CName FeaturePropertyName
		{
			get
			{
				if (_featurePropertyName == null)
				{
					_featurePropertyName = (CName) CR2WTypeManager.Create("CName", "featurePropertyName", cr2w, this);
				}
				return _featurePropertyName;
			}
			set
			{
				if (_featurePropertyName == value)
				{
					return;
				}
				_featurePropertyName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("compareFunc")] 
		public CEnum<animCompareFunc> CompareFunc
		{
			get
			{
				if (_compareFunc == null)
				{
					_compareFunc = (CEnum<animCompareFunc>) CR2WTypeManager.Create("animCompareFunc", "compareFunc", cr2w, this);
				}
				return _compareFunc;
			}
			set
			{
				if (_compareFunc == value)
				{
					return;
				}
				_compareFunc = value;
				PropertySet(this);
			}
		}

		public animAnimStateTransitionCondition_FloatFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
