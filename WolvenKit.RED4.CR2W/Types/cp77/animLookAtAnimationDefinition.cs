using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtAnimationDefinition : CVariable
	{
		private CFloat _minTransitionDuration;
		private CFloat _playAnimProbability;
		private CFloat _animDelay;
		private CArray<CName> _animations;

		[Ordinal(0)] 
		[RED("minTransitionDuration")] 
		public CFloat MinTransitionDuration
		{
			get
			{
				if (_minTransitionDuration == null)
				{
					_minTransitionDuration = (CFloat) CR2WTypeManager.Create("Float", "minTransitionDuration", cr2w, this);
				}
				return _minTransitionDuration;
			}
			set
			{
				if (_minTransitionDuration == value)
				{
					return;
				}
				_minTransitionDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playAnimProbability")] 
		public CFloat PlayAnimProbability
		{
			get
			{
				if (_playAnimProbability == null)
				{
					_playAnimProbability = (CFloat) CR2WTypeManager.Create("Float", "playAnimProbability", cr2w, this);
				}
				return _playAnimProbability;
			}
			set
			{
				if (_playAnimProbability == value)
				{
					return;
				}
				_playAnimProbability = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animDelay")] 
		public CFloat AnimDelay
		{
			get
			{
				if (_animDelay == null)
				{
					_animDelay = (CFloat) CR2WTypeManager.Create("Float", "animDelay", cr2w, this);
				}
				return _animDelay;
			}
			set
			{
				if (_animDelay == value)
				{
					return;
				}
				_animDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("animations")] 
		public CArray<CName> Animations
		{
			get
			{
				if (_animations == null)
				{
					_animations = (CArray<CName>) CR2WTypeManager.Create("array:CName", "animations", cr2w, this);
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

		public animLookAtAnimationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
