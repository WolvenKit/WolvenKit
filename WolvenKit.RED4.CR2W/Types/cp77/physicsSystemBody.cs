using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsSystemBody : physicsISystemObject
	{
		private physicsSystemBodyParams _params;
		private Transform _localToModel;
		private CArray<CHandle<physicsICollider>> _collisionShapes;
		private CName _mappedBoneName;
		private Transform _mappedBoneToBody;
		private CBool _isQueryBodyOnly;

		[Ordinal(1)] 
		[RED("params")] 
		public physicsSystemBodyParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (physicsSystemBodyParams) CR2WTypeManager.Create("physicsSystemBodyParams", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("localToModel")] 
		public Transform LocalToModel
		{
			get
			{
				if (_localToModel == null)
				{
					_localToModel = (Transform) CR2WTypeManager.Create("Transform", "localToModel", cr2w, this);
				}
				return _localToModel;
			}
			set
			{
				if (_localToModel == value)
				{
					return;
				}
				_localToModel = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("collisionShapes")] 
		public CArray<CHandle<physicsICollider>> CollisionShapes
		{
			get
			{
				if (_collisionShapes == null)
				{
					_collisionShapes = (CArray<CHandle<physicsICollider>>) CR2WTypeManager.Create("array:handle:physicsICollider", "collisionShapes", cr2w, this);
				}
				return _collisionShapes;
			}
			set
			{
				if (_collisionShapes == value)
				{
					return;
				}
				_collisionShapes = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("mappedBoneName")] 
		public CName MappedBoneName
		{
			get
			{
				if (_mappedBoneName == null)
				{
					_mappedBoneName = (CName) CR2WTypeManager.Create("CName", "mappedBoneName", cr2w, this);
				}
				return _mappedBoneName;
			}
			set
			{
				if (_mappedBoneName == value)
				{
					return;
				}
				_mappedBoneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("mappedBoneToBody")] 
		public Transform MappedBoneToBody
		{
			get
			{
				if (_mappedBoneToBody == null)
				{
					_mappedBoneToBody = (Transform) CR2WTypeManager.Create("Transform", "mappedBoneToBody", cr2w, this);
				}
				return _mappedBoneToBody;
			}
			set
			{
				if (_mappedBoneToBody == value)
				{
					return;
				}
				_mappedBoneToBody = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isQueryBodyOnly")] 
		public CBool IsQueryBodyOnly
		{
			get
			{
				if (_isQueryBodyOnly == null)
				{
					_isQueryBodyOnly = (CBool) CR2WTypeManager.Create("Bool", "isQueryBodyOnly", cr2w, this);
				}
				return _isQueryBodyOnly;
			}
			set
			{
				if (_isQueryBodyOnly == value)
				{
					return;
				}
				_isQueryBodyOnly = value;
				PropertySet(this);
			}
		}

		public physicsSystemBody(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
