using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsCollisionPreset : ISerializable
	{
		private CName _name;
		private CBool _forceEnableCollisionCallbacks;
		private CArray<CName> _collisionType;
		private CArray<CName> _collisionMask;
		private CArray<CName> _queryDetect;

		[Ordinal(0)] 
		[RED("Name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "Name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ForceEnableCollisionCallbacks")] 
		public CBool ForceEnableCollisionCallbacks
		{
			get
			{
				if (_forceEnableCollisionCallbacks == null)
				{
					_forceEnableCollisionCallbacks = (CBool) CR2WTypeManager.Create("Bool", "ForceEnableCollisionCallbacks", cr2w, this);
				}
				return _forceEnableCollisionCallbacks;
			}
			set
			{
				if (_forceEnableCollisionCallbacks == value)
				{
					return;
				}
				_forceEnableCollisionCallbacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("CollisionType")] 
		public CArray<CName> CollisionType
		{
			get
			{
				if (_collisionType == null)
				{
					_collisionType = (CArray<CName>) CR2WTypeManager.Create("array:CName", "CollisionType", cr2w, this);
				}
				return _collisionType;
			}
			set
			{
				if (_collisionType == value)
				{
					return;
				}
				_collisionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("CollisionMask")] 
		public CArray<CName> CollisionMask
		{
			get
			{
				if (_collisionMask == null)
				{
					_collisionMask = (CArray<CName>) CR2WTypeManager.Create("array:CName", "CollisionMask", cr2w, this);
				}
				return _collisionMask;
			}
			set
			{
				if (_collisionMask == value)
				{
					return;
				}
				_collisionMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("QueryDetect")] 
		public CArray<CName> QueryDetect
		{
			get
			{
				if (_queryDetect == null)
				{
					_queryDetect = (CArray<CName>) CR2WTypeManager.Create("array:CName", "QueryDetect", cr2w, this);
				}
				return _queryDetect;
			}
			set
			{
				if (_queryDetect == value)
				{
					return;
				}
				_queryDetect = value;
				PropertySet(this);
			}
		}

		public physicsCollisionPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
