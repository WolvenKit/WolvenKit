using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsICollider : ISerializable
	{
		private Transform _localToBody;
		private CName _material;
		private CArray<physicsApperanceMaterial> _materialApperanceOverrides;
		private CName _tag;
		private CBool _isImported;
		private CBool _isQueryShapeOnly;
		private CFloat _volumeModifier;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(0)] 
		[RED("localToBody")] 
		public Transform LocalToBody
		{
			get
			{
				if (_localToBody == null)
				{
					_localToBody = (Transform) CR2WTypeManager.Create("Transform", "localToBody", cr2w, this);
				}
				return _localToBody;
			}
			set
			{
				if (_localToBody == value)
				{
					return;
				}
				_localToBody = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("material")] 
		public CName Material
		{
			get
			{
				if (_material == null)
				{
					_material = (CName) CR2WTypeManager.Create("CName", "material", cr2w, this);
				}
				return _material;
			}
			set
			{
				if (_material == value)
				{
					return;
				}
				_material = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("materialApperanceOverrides")] 
		public CArray<physicsApperanceMaterial> MaterialApperanceOverrides
		{
			get
			{
				if (_materialApperanceOverrides == null)
				{
					_materialApperanceOverrides = (CArray<physicsApperanceMaterial>) CR2WTypeManager.Create("array:physicsApperanceMaterial", "materialApperanceOverrides", cr2w, this);
				}
				return _materialApperanceOverrides;
			}
			set
			{
				if (_materialApperanceOverrides == value)
				{
					return;
				}
				_materialApperanceOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isImported")] 
		public CBool IsImported
		{
			get
			{
				if (_isImported == null)
				{
					_isImported = (CBool) CR2WTypeManager.Create("Bool", "isImported", cr2w, this);
				}
				return _isImported;
			}
			set
			{
				if (_isImported == value)
				{
					return;
				}
				_isImported = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isQueryShapeOnly")] 
		public CBool IsQueryShapeOnly
		{
			get
			{
				if (_isQueryShapeOnly == null)
				{
					_isQueryShapeOnly = (CBool) CR2WTypeManager.Create("Bool", "isQueryShapeOnly", cr2w, this);
				}
				return _isQueryShapeOnly;
			}
			set
			{
				if (_isQueryShapeOnly == value)
				{
					return;
				}
				_isQueryShapeOnly = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("volumeModifier")] 
		public CFloat VolumeModifier
		{
			get
			{
				if (_volumeModifier == null)
				{
					_volumeModifier = (CFloat) CR2WTypeManager.Create("Float", "volumeModifier", cr2w, this);
				}
				return _volumeModifier;
			}
			set
			{
				if (_volumeModifier == value)
				{
					return;
				}
				_volumeModifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get
			{
				if (_filterData == null)
				{
					_filterData = (CHandle<physicsFilterData>) CR2WTypeManager.Create("handle:physicsFilterData", "filterData", cr2w, this);
				}
				return _filterData;
			}
			set
			{
				if (_filterData == value)
				{
					return;
				}
				_filterData = value;
				PropertySet(this);
			}
		}

		public physicsICollider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
