using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_LeftHandAnimation : animAnimFeature
	{
		private CBool _lockLeftHandAnimation;

		[Ordinal(0)] 
		[RED("lockLeftHandAnimation")] 
		public CBool LockLeftHandAnimation
		{
			get
			{
				if (_lockLeftHandAnimation == null)
				{
					_lockLeftHandAnimation = (CBool) CR2WTypeManager.Create("Bool", "lockLeftHandAnimation", cr2w, this);
				}
				return _lockLeftHandAnimation;
			}
			set
			{
				if (_lockLeftHandAnimation == value)
				{
					return;
				}
				_lockLeftHandAnimation = value;
				PropertySet(this);
			}
		}

		public AnimFeature_LeftHandAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
