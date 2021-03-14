using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCameraAnimationRid : CVariable
	{
		private scnRidTag _tag;
		private CHandle<animIAnimationBuffer> _animation;

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
		[RED("animation")] 
		public CHandle<animIAnimationBuffer> Animation
		{
			get
			{
				if (_animation == null)
				{
					_animation = (CHandle<animIAnimationBuffer>) CR2WTypeManager.Create("handle:animIAnimationBuffer", "animation", cr2w, this);
				}
				return _animation;
			}
			set
			{
				if (_animation == value)
				{
					return;
				}
				_animation = value;
				PropertySet(this);
			}
		}

		public scnCameraAnimationRid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
