using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_AdHocAnimation : animAnimFeature
	{
		private CBool _isActive;
		private CBool _useBothHands;
		private CInt32 _animationIndex;

		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useBothHands")] 
		public CBool UseBothHands
		{
			get
			{
				if (_useBothHands == null)
				{
					_useBothHands = (CBool) CR2WTypeManager.Create("Bool", "useBothHands", cr2w, this);
				}
				return _useBothHands;
			}
			set
			{
				if (_useBothHands == value)
				{
					return;
				}
				_useBothHands = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animationIndex")] 
		public CInt32 AnimationIndex
		{
			get
			{
				if (_animationIndex == null)
				{
					_animationIndex = (CInt32) CR2WTypeManager.Create("Int32", "animationIndex", cr2w, this);
				}
				return _animationIndex;
			}
			set
			{
				if (_animationIndex == value)
				{
					return;
				}
				_animationIndex = value;
				PropertySet(this);
			}
		}

		public AnimFeature_AdHocAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
