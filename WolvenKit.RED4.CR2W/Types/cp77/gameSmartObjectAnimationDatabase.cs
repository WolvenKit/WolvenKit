using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectAnimationDatabase : ISerializable
	{
		private CArray<gameAnimationExtractedData> _animationData;
		private CArray<gameBodyTypeData> _bodyTypesData;

		[Ordinal(0)] 
		[RED("animationData")] 
		public CArray<gameAnimationExtractedData> AnimationData
		{
			get
			{
				if (_animationData == null)
				{
					_animationData = (CArray<gameAnimationExtractedData>) CR2WTypeManager.Create("array:gameAnimationExtractedData", "animationData", cr2w, this);
				}
				return _animationData;
			}
			set
			{
				if (_animationData == value)
				{
					return;
				}
				_animationData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("bodyTypesData")] 
		public CArray<gameBodyTypeData> BodyTypesData
		{
			get
			{
				if (_bodyTypesData == null)
				{
					_bodyTypesData = (CArray<gameBodyTypeData>) CR2WTypeManager.Create("array:gameBodyTypeData", "bodyTypesData", cr2w, this);
				}
				return _bodyTypesData;
			}
			set
			{
				if (_bodyTypesData == value)
				{
					return;
				}
				_bodyTypesData = value;
				PropertySet(this);
			}
		}

		public gameSmartObjectAnimationDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
