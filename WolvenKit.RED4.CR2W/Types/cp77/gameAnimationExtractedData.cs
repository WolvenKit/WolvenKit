using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAnimationExtractedData : CVariable
	{
		private CName _animationName;
		private CArray<gameAnimationTransforms> _animsetsExtractedTransforms;
		private CEnum<gameSmartObjectPointType> _smartObjectPointType;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animsetsExtractedTransforms")] 
		public CArray<gameAnimationTransforms> AnimsetsExtractedTransforms
		{
			get
			{
				if (_animsetsExtractedTransforms == null)
				{
					_animsetsExtractedTransforms = (CArray<gameAnimationTransforms>) CR2WTypeManager.Create("array:gameAnimationTransforms", "animsetsExtractedTransforms", cr2w, this);
				}
				return _animsetsExtractedTransforms;
			}
			set
			{
				if (_animsetsExtractedTransforms == value)
				{
					return;
				}
				_animsetsExtractedTransforms = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("smartObjectPointType")] 
		public CEnum<gameSmartObjectPointType> SmartObjectPointType
		{
			get
			{
				if (_smartObjectPointType == null)
				{
					_smartObjectPointType = (CEnum<gameSmartObjectPointType>) CR2WTypeManager.Create("gameSmartObjectPointType", "smartObjectPointType", cr2w, this);
				}
				return _smartObjectPointType;
			}
			set
			{
				if (_smartObjectPointType == value)
				{
					return;
				}
				_smartObjectPointType = value;
				PropertySet(this);
			}
		}

		public gameAnimationExtractedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
