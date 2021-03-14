using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopReExportOptions : CVariable
	{
		private CArray<CName> _occlusionExportOptNames;
		private CArray<CBool> _occlusionExportOptValues;
		private CArray<CBool> _typeExportOptions;
		private CString _filePath;
		private CBool _runDispatcher;
		private CArray<CString> _files;
		private CString _depotPath;
		private AbsolutePathSerializable _maskDumpFilePath;
		private CBool _exportMaterials;
		private CString _hjobToken;
		private CString _hjobParams;
		private CString _hjobParamsOutput;
		private CString _assetName;
		private CString _rigs;
		private CString _hjobTemplate;
		private CString _bodyType;
		private CString _baseType;
		private Box _exportBounds;
		private Vector3 _referencePoint;
		private CArray<CString> _assetPaths;
		private AbsolutePathSerializable _jsonFile;
		private CUInt8 _prefabType;
		private CBool _proxyFromProxy;
		private CBool _onlyProxy;
		private CBool _exportTextures;
		private CDouble _minBBoxDiag;
		private CDouble _asBBoxThreshold;
		private CDouble _asBBoxPrefabsThreshold;
		private CDouble _asBBoxPrefabsSubdivide;
		private CBool _asBBoxPrefabsForceLast;
		private CBool _skipCollisions;
		private CFloat _preferSmallProxiesTreshold;

		[Ordinal(0)] 
		[RED("occlusionExportOptNames")] 
		public CArray<CName> OcclusionExportOptNames
		{
			get
			{
				if (_occlusionExportOptNames == null)
				{
					_occlusionExportOptNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "occlusionExportOptNames", cr2w, this);
				}
				return _occlusionExportOptNames;
			}
			set
			{
				if (_occlusionExportOptNames == value)
				{
					return;
				}
				_occlusionExportOptNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("occlusionExportOptValues")] 
		public CArray<CBool> OcclusionExportOptValues
		{
			get
			{
				if (_occlusionExportOptValues == null)
				{
					_occlusionExportOptValues = (CArray<CBool>) CR2WTypeManager.Create("array:Bool", "occlusionExportOptValues", cr2w, this);
				}
				return _occlusionExportOptValues;
			}
			set
			{
				if (_occlusionExportOptValues == value)
				{
					return;
				}
				_occlusionExportOptValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("typeExportOptions")] 
		public CArray<CBool> TypeExportOptions
		{
			get
			{
				if (_typeExportOptions == null)
				{
					_typeExportOptions = (CArray<CBool>) CR2WTypeManager.Create("array:Bool", "typeExportOptions", cr2w, this);
				}
				return _typeExportOptions;
			}
			set
			{
				if (_typeExportOptions == value)
				{
					return;
				}
				_typeExportOptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("filePath")] 
		public CString FilePath
		{
			get
			{
				if (_filePath == null)
				{
					_filePath = (CString) CR2WTypeManager.Create("String", "filePath", cr2w, this);
				}
				return _filePath;
			}
			set
			{
				if (_filePath == value)
				{
					return;
				}
				_filePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("runDispatcher")] 
		public CBool RunDispatcher
		{
			get
			{
				if (_runDispatcher == null)
				{
					_runDispatcher = (CBool) CR2WTypeManager.Create("Bool", "runDispatcher", cr2w, this);
				}
				return _runDispatcher;
			}
			set
			{
				if (_runDispatcher == value)
				{
					return;
				}
				_runDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("files")] 
		public CArray<CString> Files
		{
			get
			{
				if (_files == null)
				{
					_files = (CArray<CString>) CR2WTypeManager.Create("array:String", "files", cr2w, this);
				}
				return _files;
			}
			set
			{
				if (_files == value)
				{
					return;
				}
				_files = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("depotPath")] 
		public CString DepotPath
		{
			get
			{
				if (_depotPath == null)
				{
					_depotPath = (CString) CR2WTypeManager.Create("String", "depotPath", cr2w, this);
				}
				return _depotPath;
			}
			set
			{
				if (_depotPath == value)
				{
					return;
				}
				_depotPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maskDumpFilePath")] 
		public AbsolutePathSerializable MaskDumpFilePath
		{
			get
			{
				if (_maskDumpFilePath == null)
				{
					_maskDumpFilePath = (AbsolutePathSerializable) CR2WTypeManager.Create("AbsolutePathSerializable", "maskDumpFilePath", cr2w, this);
				}
				return _maskDumpFilePath;
			}
			set
			{
				if (_maskDumpFilePath == value)
				{
					return;
				}
				_maskDumpFilePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("exportMaterials")] 
		public CBool ExportMaterials
		{
			get
			{
				if (_exportMaterials == null)
				{
					_exportMaterials = (CBool) CR2WTypeManager.Create("Bool", "exportMaterials", cr2w, this);
				}
				return _exportMaterials;
			}
			set
			{
				if (_exportMaterials == value)
				{
					return;
				}
				_exportMaterials = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("hjobToken")] 
		public CString HjobToken
		{
			get
			{
				if (_hjobToken == null)
				{
					_hjobToken = (CString) CR2WTypeManager.Create("String", "hjobToken", cr2w, this);
				}
				return _hjobToken;
			}
			set
			{
				if (_hjobToken == value)
				{
					return;
				}
				_hjobToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("hjobParams")] 
		public CString HjobParams
		{
			get
			{
				if (_hjobParams == null)
				{
					_hjobParams = (CString) CR2WTypeManager.Create("String", "hjobParams", cr2w, this);
				}
				return _hjobParams;
			}
			set
			{
				if (_hjobParams == value)
				{
					return;
				}
				_hjobParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("hjobParamsOutput")] 
		public CString HjobParamsOutput
		{
			get
			{
				if (_hjobParamsOutput == null)
				{
					_hjobParamsOutput = (CString) CR2WTypeManager.Create("String", "hjobParamsOutput", cr2w, this);
				}
				return _hjobParamsOutput;
			}
			set
			{
				if (_hjobParamsOutput == value)
				{
					return;
				}
				_hjobParamsOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("assetName")] 
		public CString AssetName
		{
			get
			{
				if (_assetName == null)
				{
					_assetName = (CString) CR2WTypeManager.Create("String", "assetName", cr2w, this);
				}
				return _assetName;
			}
			set
			{
				if (_assetName == value)
				{
					return;
				}
				_assetName = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("rigs")] 
		public CString Rigs
		{
			get
			{
				if (_rigs == null)
				{
					_rigs = (CString) CR2WTypeManager.Create("String", "rigs", cr2w, this);
				}
				return _rigs;
			}
			set
			{
				if (_rigs == value)
				{
					return;
				}
				_rigs = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("hjobTemplate")] 
		public CString HjobTemplate
		{
			get
			{
				if (_hjobTemplate == null)
				{
					_hjobTemplate = (CString) CR2WTypeManager.Create("String", "hjobTemplate", cr2w, this);
				}
				return _hjobTemplate;
			}
			set
			{
				if (_hjobTemplate == value)
				{
					return;
				}
				_hjobTemplate = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("bodyType")] 
		public CString BodyType
		{
			get
			{
				if (_bodyType == null)
				{
					_bodyType = (CString) CR2WTypeManager.Create("String", "bodyType", cr2w, this);
				}
				return _bodyType;
			}
			set
			{
				if (_bodyType == value)
				{
					return;
				}
				_bodyType = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("baseType")] 
		public CString BaseType
		{
			get
			{
				if (_baseType == null)
				{
					_baseType = (CString) CR2WTypeManager.Create("String", "baseType", cr2w, this);
				}
				return _baseType;
			}
			set
			{
				if (_baseType == value)
				{
					return;
				}
				_baseType = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("exportBounds")] 
		public Box ExportBounds
		{
			get
			{
				if (_exportBounds == null)
				{
					_exportBounds = (Box) CR2WTypeManager.Create("Box", "exportBounds", cr2w, this);
				}
				return _exportBounds;
			}
			set
			{
				if (_exportBounds == value)
				{
					return;
				}
				_exportBounds = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("referencePoint")] 
		public Vector3 ReferencePoint
		{
			get
			{
				if (_referencePoint == null)
				{
					_referencePoint = (Vector3) CR2WTypeManager.Create("Vector3", "referencePoint", cr2w, this);
				}
				return _referencePoint;
			}
			set
			{
				if (_referencePoint == value)
				{
					return;
				}
				_referencePoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("assetPaths")] 
		public CArray<CString> AssetPaths
		{
			get
			{
				if (_assetPaths == null)
				{
					_assetPaths = (CArray<CString>) CR2WTypeManager.Create("array:String", "assetPaths", cr2w, this);
				}
				return _assetPaths;
			}
			set
			{
				if (_assetPaths == value)
				{
					return;
				}
				_assetPaths = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("jsonFile")] 
		public AbsolutePathSerializable JsonFile
		{
			get
			{
				if (_jsonFile == null)
				{
					_jsonFile = (AbsolutePathSerializable) CR2WTypeManager.Create("AbsolutePathSerializable", "jsonFile", cr2w, this);
				}
				return _jsonFile;
			}
			set
			{
				if (_jsonFile == value)
				{
					return;
				}
				_jsonFile = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("prefabType")] 
		public CUInt8 PrefabType
		{
			get
			{
				if (_prefabType == null)
				{
					_prefabType = (CUInt8) CR2WTypeManager.Create("Uint8", "prefabType", cr2w, this);
				}
				return _prefabType;
			}
			set
			{
				if (_prefabType == value)
				{
					return;
				}
				_prefabType = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("proxyFromProxy")] 
		public CBool ProxyFromProxy
		{
			get
			{
				if (_proxyFromProxy == null)
				{
					_proxyFromProxy = (CBool) CR2WTypeManager.Create("Bool", "proxyFromProxy", cr2w, this);
				}
				return _proxyFromProxy;
			}
			set
			{
				if (_proxyFromProxy == value)
				{
					return;
				}
				_proxyFromProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("onlyProxy")] 
		public CBool OnlyProxy
		{
			get
			{
				if (_onlyProxy == null)
				{
					_onlyProxy = (CBool) CR2WTypeManager.Create("Bool", "onlyProxy", cr2w, this);
				}
				return _onlyProxy;
			}
			set
			{
				if (_onlyProxy == value)
				{
					return;
				}
				_onlyProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("exportTextures")] 
		public CBool ExportTextures
		{
			get
			{
				if (_exportTextures == null)
				{
					_exportTextures = (CBool) CR2WTypeManager.Create("Bool", "exportTextures", cr2w, this);
				}
				return _exportTextures;
			}
			set
			{
				if (_exportTextures == value)
				{
					return;
				}
				_exportTextures = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("minBBoxDiag")] 
		public CDouble MinBBoxDiag
		{
			get
			{
				if (_minBBoxDiag == null)
				{
					_minBBoxDiag = (CDouble) CR2WTypeManager.Create("Double", "minBBoxDiag", cr2w, this);
				}
				return _minBBoxDiag;
			}
			set
			{
				if (_minBBoxDiag == value)
				{
					return;
				}
				_minBBoxDiag = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("asBBoxThreshold")] 
		public CDouble AsBBoxThreshold
		{
			get
			{
				if (_asBBoxThreshold == null)
				{
					_asBBoxThreshold = (CDouble) CR2WTypeManager.Create("Double", "asBBoxThreshold", cr2w, this);
				}
				return _asBBoxThreshold;
			}
			set
			{
				if (_asBBoxThreshold == value)
				{
					return;
				}
				_asBBoxThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("asBBoxPrefabsThreshold")] 
		public CDouble AsBBoxPrefabsThreshold
		{
			get
			{
				if (_asBBoxPrefabsThreshold == null)
				{
					_asBBoxPrefabsThreshold = (CDouble) CR2WTypeManager.Create("Double", "asBBoxPrefabsThreshold", cr2w, this);
				}
				return _asBBoxPrefabsThreshold;
			}
			set
			{
				if (_asBBoxPrefabsThreshold == value)
				{
					return;
				}
				_asBBoxPrefabsThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("asBBoxPrefabsSubdivide")] 
		public CDouble AsBBoxPrefabsSubdivide
		{
			get
			{
				if (_asBBoxPrefabsSubdivide == null)
				{
					_asBBoxPrefabsSubdivide = (CDouble) CR2WTypeManager.Create("Double", "asBBoxPrefabsSubdivide", cr2w, this);
				}
				return _asBBoxPrefabsSubdivide;
			}
			set
			{
				if (_asBBoxPrefabsSubdivide == value)
				{
					return;
				}
				_asBBoxPrefabsSubdivide = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("asBBoxPrefabsForceLast")] 
		public CBool AsBBoxPrefabsForceLast
		{
			get
			{
				if (_asBBoxPrefabsForceLast == null)
				{
					_asBBoxPrefabsForceLast = (CBool) CR2WTypeManager.Create("Bool", "asBBoxPrefabsForceLast", cr2w, this);
				}
				return _asBBoxPrefabsForceLast;
			}
			set
			{
				if (_asBBoxPrefabsForceLast == value)
				{
					return;
				}
				_asBBoxPrefabsForceLast = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("skipCollisions")] 
		public CBool SkipCollisions
		{
			get
			{
				if (_skipCollisions == null)
				{
					_skipCollisions = (CBool) CR2WTypeManager.Create("Bool", "skipCollisions", cr2w, this);
				}
				return _skipCollisions;
			}
			set
			{
				if (_skipCollisions == value)
				{
					return;
				}
				_skipCollisions = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("preferSmallProxiesTreshold")] 
		public CFloat PreferSmallProxiesTreshold
		{
			get
			{
				if (_preferSmallProxiesTreshold == null)
				{
					_preferSmallProxiesTreshold = (CFloat) CR2WTypeManager.Create("Float", "preferSmallProxiesTreshold", cr2w, this);
				}
				return _preferSmallProxiesTreshold;
			}
			set
			{
				if (_preferSmallProxiesTreshold == value)
				{
					return;
				}
				_preferSmallProxiesTreshold = value;
				PropertySet(this);
			}
		}

		public interopReExportOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
