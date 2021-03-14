using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerDeathAnimation : animAnimFeature
	{
		private CInt32 _animation;

		[Ordinal(0)] 
		[RED("animation")] 
		public CInt32 Animation
		{
			get
			{
				if (_animation == null)
				{
					_animation = (CInt32) CR2WTypeManager.Create("Int32", "animation", cr2w, this);
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

		public AnimFeature_PlayerDeathAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
