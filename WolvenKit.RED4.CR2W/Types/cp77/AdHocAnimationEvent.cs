using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AdHocAnimationEvent : redEvent
	{
		private CInt32 _animationIndex;
		private CBool _useBothHands;
		private CBool _unequipWeapon;

		[Ordinal(0)] 
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
		[RED("unequipWeapon")] 
		public CBool UnequipWeapon
		{
			get
			{
				if (_unequipWeapon == null)
				{
					_unequipWeapon = (CBool) CR2WTypeManager.Create("Bool", "unequipWeapon", cr2w, this);
				}
				return _unequipWeapon;
			}
			set
			{
				if (_unequipWeapon == value)
				{
					return;
				}
				_unequipWeapon = value;
				PropertySet(this);
			}
		}

		public AdHocAnimationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
