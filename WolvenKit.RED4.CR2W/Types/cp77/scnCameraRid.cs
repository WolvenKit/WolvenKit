using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCameraRid : CVariable
	{
		private scnRidTag _tag;
		private CArray<scnCameraAnimationRid> _animations;

		[Ordinal(0)] 
		[RED("tag")] 
		public scnRidTag Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (scnRidTag) CR2WTypeManager.Create("scnRidTag", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animations")] 
		public CArray<scnCameraAnimationRid> Animations
		{
			get
			{
				if (_animations == null)
				{
					_animations = (CArray<scnCameraAnimationRid>) CR2WTypeManager.Create("array:scnCameraAnimationRid", "animations", cr2w, this);
				}
				return _animations;
			}
			set
			{
				if (_animations == value)
				{
					return;
				}
				_animations = value;
				PropertySet(this);
			}
		}

		public scnCameraRid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
