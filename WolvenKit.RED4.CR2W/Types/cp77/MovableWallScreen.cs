using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MovableWallScreen : Door
	{
		private CFloat _animationLength;
		private CHandle<AnimFeature_SimpleDevice> _animFeature;

		[Ordinal(135)] 
		[RED("animationLength")] 
		public CFloat AnimationLength
		{
			get
			{
				if (_animationLength == null)
				{
					_animationLength = (CFloat) CR2WTypeManager.Create("Float", "animationLength", cr2w, this);
				}
				return _animationLength;
			}
			set
			{
				if (_animationLength == value)
				{
					return;
				}
				_animationLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(136)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_SimpleDevice>) CR2WTypeManager.Create("handle:AnimFeature_SimpleDevice", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		public MovableWallScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
