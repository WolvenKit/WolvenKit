using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gametargetingSystemHitInfo : CVariable
	{
		private CUInt64 _queryMask;
		private entEntityID _entityId;
		private wCHandle<entEntity> _entity;
		private wCHandle<entIComponent> _component;
		private Vector4 _aimStartPosition;
		private Vector4 _closestHitPosition;
		private CBool _isTransparent;

		[Ordinal(0)] 
		[RED("queryMask")] 
		public CUInt64 QueryMask
		{
			get
			{
				if (_queryMask == null)
				{
					_queryMask = (CUInt64) CR2WTypeManager.Create("Uint64", "queryMask", cr2w, this);
				}
				return _queryMask;
			}
			set
			{
				if (_queryMask == value)
				{
					return;
				}
				_queryMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get
			{
				if (_entityId == null)
				{
					_entityId = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityId", cr2w, this);
				}
				return _entityId;
			}
			set
			{
				if (_entityId == value)
				{
					return;
				}
				_entityId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("component")] 
		public wCHandle<entIComponent> Component
		{
			get
			{
				if (_component == null)
				{
					_component = (wCHandle<entIComponent>) CR2WTypeManager.Create("whandle:entIComponent", "component", cr2w, this);
				}
				return _component;
			}
			set
			{
				if (_component == value)
				{
					return;
				}
				_component = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("aimStartPosition")] 
		public Vector4 AimStartPosition
		{
			get
			{
				if (_aimStartPosition == null)
				{
					_aimStartPosition = (Vector4) CR2WTypeManager.Create("Vector4", "aimStartPosition", cr2w, this);
				}
				return _aimStartPosition;
			}
			set
			{
				if (_aimStartPosition == value)
				{
					return;
				}
				_aimStartPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("closestHitPosition")] 
		public Vector4 ClosestHitPosition
		{
			get
			{
				if (_closestHitPosition == null)
				{
					_closestHitPosition = (Vector4) CR2WTypeManager.Create("Vector4", "closestHitPosition", cr2w, this);
				}
				return _closestHitPosition;
			}
			set
			{
				if (_closestHitPosition == value)
				{
					return;
				}
				_closestHitPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isTransparent")] 
		public CBool IsTransparent
		{
			get
			{
				if (_isTransparent == null)
				{
					_isTransparent = (CBool) CR2WTypeManager.Create("Bool", "isTransparent", cr2w, this);
				}
				return _isTransparent;
			}
			set
			{
				if (_isTransparent == value)
				{
					return;
				}
				_isTransparent = value;
				PropertySet(this);
			}
		}

		public gametargetingSystemHitInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
