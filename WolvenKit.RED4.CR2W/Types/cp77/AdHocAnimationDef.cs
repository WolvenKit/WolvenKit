using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AdHocAnimationDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isActive;
		private gamebbScriptID_Int32 _animationIndex;
		private gamebbScriptID_Bool _useBothHands;
		private gamebbScriptID_Bool _unequipWeapon;

		[Ordinal(0)] 
		[RED("IsActive")] 
		public gamebbScriptID_Bool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsActive", cr2w, this);
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
		[RED("AnimationIndex")] 
		public gamebbScriptID_Int32 AnimationIndex
		{
			get
			{
				if (_animationIndex == null)
				{
					_animationIndex = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "AnimationIndex", cr2w, this);
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

		[Ordinal(2)] 
		[RED("UseBothHands")] 
		public gamebbScriptID_Bool UseBothHands
		{
			get
			{
				if (_useBothHands == null)
				{
					_useBothHands = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "UseBothHands", cr2w, this);
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

		[Ordinal(3)] 
		[RED("UnequipWeapon")] 
		public gamebbScriptID_Bool UnequipWeapon
		{
			get
			{
				if (_unequipWeapon == null)
				{
					_unequipWeapon = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "UnequipWeapon", cr2w, this);
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

		public AdHocAnimationDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
