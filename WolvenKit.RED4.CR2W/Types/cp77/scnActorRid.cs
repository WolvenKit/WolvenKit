using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnActorRid : CVariable
	{
		private scnRidTag _tag;
		private CArray<scnAnimationRid> _animations;
		private CArray<scnAnimationRid> _facialAnimations;
		private CArray<scnAnimationRid> _cyberwareAnimations;

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
		public CArray<scnAnimationRid> Animations
		{
			get
			{
				if (_animations == null)
				{
					_animations = (CArray<scnAnimationRid>) CR2WTypeManager.Create("array:scnAnimationRid", "animations", cr2w, this);
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

		[Ordinal(2)] 
		[RED("facialAnimations")] 
		public CArray<scnAnimationRid> FacialAnimations
		{
			get
			{
				if (_facialAnimations == null)
				{
					_facialAnimations = (CArray<scnAnimationRid>) CR2WTypeManager.Create("array:scnAnimationRid", "facialAnimations", cr2w, this);
				}
				return _facialAnimations;
			}
			set
			{
				if (_facialAnimations == value)
				{
					return;
				}
				_facialAnimations = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cyberwareAnimations")] 
		public CArray<scnAnimationRid> CyberwareAnimations
		{
			get
			{
				if (_cyberwareAnimations == null)
				{
					_cyberwareAnimations = (CArray<scnAnimationRid>) CR2WTypeManager.Create("array:scnAnimationRid", "cyberwareAnimations", cr2w, this);
				}
				return _cyberwareAnimations;
			}
			set
			{
				if (_cyberwareAnimations == value)
				{
					return;
				}
				_cyberwareAnimations = value;
				PropertySet(this);
			}
		}

		public scnActorRid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
