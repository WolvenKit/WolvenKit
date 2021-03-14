using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMountedObjectInfo : ISerializable
	{
		private CBool _isFirst;
		private CBool _isPlayer;
		private gameEntityReference _ref;
		private CBool _onMount;
		private CEnum<gameMountingSlotRole> _role;

		[Ordinal(0)] 
		[RED("isFirst")] 
		public CBool IsFirst
		{
			get
			{
				if (_isFirst == null)
				{
					_isFirst = (CBool) CR2WTypeManager.Create("Bool", "isFirst", cr2w, this);
				}
				return _isFirst;
			}
			set
			{
				if (_isFirst == value)
				{
					return;
				}
				_isFirst = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ref")] 
		public gameEntityReference Ref
		{
			get
			{
				if (_ref == null)
				{
					_ref = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "ref", cr2w, this);
				}
				return _ref;
			}
			set
			{
				if (_ref == value)
				{
					return;
				}
				_ref = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("onMount")] 
		public CBool OnMount
		{
			get
			{
				if (_onMount == null)
				{
					_onMount = (CBool) CR2WTypeManager.Create("Bool", "onMount", cr2w, this);
				}
				return _onMount;
			}
			set
			{
				if (_onMount == value)
				{
					return;
				}
				_onMount = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("role")] 
		public CEnum<gameMountingSlotRole> Role
		{
			get
			{
				if (_role == null)
				{
					_role = (CEnum<gameMountingSlotRole>) CR2WTypeManager.Create("gameMountingSlotRole", "role", cr2w, this);
				}
				return _role;
			}
			set
			{
				if (_role == value)
				{
					return;
				}
				_role = value;
				PropertySet(this);
			}
		}

		public questMountedObjectInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
