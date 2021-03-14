using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_IntEdgeFeature : animIAnimStateTransitionCondition
	{
		private CName _featureName;
		private CName _featurePropertyName;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		public animAnimStateTransitionCondition_IntEdgeFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
