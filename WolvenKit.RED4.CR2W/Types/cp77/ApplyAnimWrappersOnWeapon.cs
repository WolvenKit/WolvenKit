using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyAnimWrappersOnWeapon : AIbehaviortaskScript
	{
		private CName _wrapperName;
		private wCHandle<gamedataAIActionTarget_Record> _refOwner;
		private wCHandle<gameObject> _owner;
		private Vector4 _ownerPosition;
		private CHandle<entAnimationControllerComponent> _animationController;

		[Ordinal(0)] 
		[RED("wrapperName")] 
		public CName WrapperName
		{
			get
			{
				if (_wrapperName == null)
				{
					_wrapperName = (CName) CR2WTypeManager.Create("CName", "wrapperName", cr2w, this);
				}
				return _wrapperName;
			}
			set
			{
				if (_wrapperName == value)
				{
					return;
				}
				_wrapperName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("refOwner")] 
		public wCHandle<gamedataAIActionTarget_Record> RefOwner
		{
			get
			{
				if (_refOwner == null)
				{
					_refOwner = (wCHandle<gamedataAIActionTarget_Record>) CR2WTypeManager.Create("whandle:gamedataAIActionTarget_Record", "refOwner", cr2w, this);
				}
				return _refOwner;
			}
			set
			{
				if (_refOwner == value)
				{
					return;
				}
				_refOwner = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ownerPosition")] 
		public Vector4 OwnerPosition
		{
			get
			{
				if (_ownerPosition == null)
				{
					_ownerPosition = (Vector4) CR2WTypeManager.Create("Vector4", "ownerPosition", cr2w, this);
				}
				return _ownerPosition;
			}
			set
			{
				if (_ownerPosition == value)
				{
					return;
				}
				_ownerPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get
			{
				if (_animationController == null)
				{
					_animationController = (CHandle<entAnimationControllerComponent>) CR2WTypeManager.Create("handle:entAnimationControllerComponent", "animationController", cr2w, this);
				}
				return _animationController;
			}
			set
			{
				if (_animationController == value)
				{
					return;
				}
				_animationController = value;
				PropertySet(this);
			}
		}

		public ApplyAnimWrappersOnWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
