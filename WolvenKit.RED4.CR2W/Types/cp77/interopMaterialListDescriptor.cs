using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopMaterialListDescriptor : CVariable
	{
		private CString _chunksInfo;
		private CString _chunksLODInfo;
		private CUInt32 _numLayers;
		private CBool _isForward;
		private CBool _isMultilayer;
		private CBool _isLocalInstance;
		private CBool _isTemplate;
		private CUInt32 _itemMaterialIndex;
		private CString _materialName;
		private CString _appearanceName;
		private CArray<CString> _availableMaterials;

		[Ordinal(0)] 
		[RED("chunksInfo")] 
		public CString ChunksInfo
		{
			get
			{
				if (_chunksInfo == null)
				{
					_chunksInfo = (CString) CR2WTypeManager.Create("String", "chunksInfo", cr2w, this);
				}
				return _chunksInfo;
			}
			set
			{
				if (_chunksInfo == value)
				{
					return;
				}
				_chunksInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("chunksLODInfo")] 
		public CString ChunksLODInfo
		{
			get
			{
				if (_chunksLODInfo == null)
				{
					_chunksLODInfo = (CString) CR2WTypeManager.Create("String", "chunksLODInfo", cr2w, this);
				}
				return _chunksLODInfo;
			}
			set
			{
				if (_chunksLODInfo == value)
				{
					return;
				}
				_chunksLODInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numLayers")] 
		public CUInt32 NumLayers
		{
			get
			{
				if (_numLayers == null)
				{
					_numLayers = (CUInt32) CR2WTypeManager.Create("Uint32", "numLayers", cr2w, this);
				}
				return _numLayers;
			}
			set
			{
				if (_numLayers == value)
				{
					return;
				}
				_numLayers = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isForward")] 
		public CBool IsForward
		{
			get
			{
				if (_isForward == null)
				{
					_isForward = (CBool) CR2WTypeManager.Create("Bool", "isForward", cr2w, this);
				}
				return _isForward;
			}
			set
			{
				if (_isForward == value)
				{
					return;
				}
				_isForward = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isMultilayer")] 
		public CBool IsMultilayer
		{
			get
			{
				if (_isMultilayer == null)
				{
					_isMultilayer = (CBool) CR2WTypeManager.Create("Bool", "isMultilayer", cr2w, this);
				}
				return _isMultilayer;
			}
			set
			{
				if (_isMultilayer == value)
				{
					return;
				}
				_isMultilayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isLocalInstance")] 
		public CBool IsLocalInstance
		{
			get
			{
				if (_isLocalInstance == null)
				{
					_isLocalInstance = (CBool) CR2WTypeManager.Create("Bool", "isLocalInstance", cr2w, this);
				}
				return _isLocalInstance;
			}
			set
			{
				if (_isLocalInstance == value)
				{
					return;
				}
				_isLocalInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isTemplate")] 
		public CBool IsTemplate
		{
			get
			{
				if (_isTemplate == null)
				{
					_isTemplate = (CBool) CR2WTypeManager.Create("Bool", "isTemplate", cr2w, this);
				}
				return _isTemplate;
			}
			set
			{
				if (_isTemplate == value)
				{
					return;
				}
				_isTemplate = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("itemMaterialIndex")] 
		public CUInt32 ItemMaterialIndex
		{
			get
			{
				if (_itemMaterialIndex == null)
				{
					_itemMaterialIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "itemMaterialIndex", cr2w, this);
				}
				return _itemMaterialIndex;
			}
			set
			{
				if (_itemMaterialIndex == value)
				{
					return;
				}
				_itemMaterialIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("materialName")] 
		public CString MaterialName
		{
			get
			{
				if (_materialName == null)
				{
					_materialName = (CString) CR2WTypeManager.Create("String", "materialName", cr2w, this);
				}
				return _materialName;
			}
			set
			{
				if (_materialName == value)
				{
					return;
				}
				_materialName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("appearanceName")] 
		public CString AppearanceName
		{
			get
			{
				if (_appearanceName == null)
				{
					_appearanceName = (CString) CR2WTypeManager.Create("String", "appearanceName", cr2w, this);
				}
				return _appearanceName;
			}
			set
			{
				if (_appearanceName == value)
				{
					return;
				}
				_appearanceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("availableMaterials")] 
		public CArray<CString> AvailableMaterials
		{
			get
			{
				if (_availableMaterials == null)
				{
					_availableMaterials = (CArray<CString>) CR2WTypeManager.Create("array:String", "availableMaterials", cr2w, this);
				}
				return _availableMaterials;
			}
			set
			{
				if (_availableMaterials == value)
				{
					return;
				}
				_availableMaterials = value;
				PropertySet(this);
			}
		}

		public interopMaterialListDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
