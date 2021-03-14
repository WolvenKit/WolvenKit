using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entInstancedAnimationComponent : entISkinableComponent
	{
		private rRef<animAnimSet> _animations;
		private CName _animToSample;
		private CName _variantAnimToSample;
		private CName _variantTriggerTag;

		[Ordinal(5)] 
		[RED("animations")] 
		public rRef<animAnimSet> Animations
		{
			get
			{
				if (_animations == null)
				{
					_animations = (rRef<animAnimSet>) CR2WTypeManager.Create("rRef:animAnimSet", "animations", cr2w, this);
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

		[Ordinal(6)] 
		[RED("animToSample")] 
		public CName AnimToSample
		{
			get
			{
				if (_animToSample == null)
				{
					_animToSample = (CName) CR2WTypeManager.Create("CName", "animToSample", cr2w, this);
				}
				return _animToSample;
			}
			set
			{
				if (_animToSample == value)
				{
					return;
				}
				_animToSample = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("variantAnimToSample")] 
		public CName VariantAnimToSample
		{
			get
			{
				if (_variantAnimToSample == null)
				{
					_variantAnimToSample = (CName) CR2WTypeManager.Create("CName", "variantAnimToSample", cr2w, this);
				}
				return _variantAnimToSample;
			}
			set
			{
				if (_variantAnimToSample == value)
				{
					return;
				}
				_variantAnimToSample = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("variantTriggerTag")] 
		public CName VariantTriggerTag
		{
			get
			{
				if (_variantTriggerTag == null)
				{
					_variantTriggerTag = (CName) CR2WTypeManager.Create("CName", "variantTriggerTag", cr2w, this);
				}
				return _variantTriggerTag;
			}
			set
			{
				if (_variantTriggerTag == value)
				{
					return;
				}
				_variantTriggerTag = value;
				PropertySet(this);
			}
		}

		public entInstancedAnimationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
