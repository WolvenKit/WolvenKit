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
		private CBool _generatePlayerBlockingCollision;

		[Ordinal(0)] 
		[RED("occlusionExportOptNames")] 
		public CArray<CName> OcclusionExportOptNames
		{
			get => GetProperty(ref _occlusionExportOptNames);
			set => SetProperty(ref _occlusionExportOptNames, value);
		}

		[Ordinal(1)] 
		[RED("occlusionExportOptValues")] 
		public CArray<CBool> OcclusionExportOptValues
		{
			get => GetProperty(ref _occlusionExportOptValues);
			set => SetProperty(ref _occlusionExportOptValues, value);
		}

		[Ordinal(2)] 
		[RED("typeExportOptions")] 
		public CArray<CBool> TypeExportOptions
		{
			get => GetProperty(ref _typeExportOptions);
			set => SetProperty(ref _typeExportOptions, value);
		}

		[Ordinal(3)] 
		[RED("filePath")] 
		public CString FilePath
		{
			get => GetProperty(ref _filePath);
			set => SetProperty(ref _filePath, value);
		}

		[Ordinal(4)] 
		[RED("runDispatcher")] 
		public CBool RunDispatcher
		{
			get => GetProperty(ref _runDispatcher);
			set => SetProperty(ref _runDispatcher, value);
		}

		[Ordinal(5)] 
		[RED("files")] 
		public CArray<CString> Files
		{
			get => GetProperty(ref _files);
			set => SetProperty(ref _files, value);
		}

		[Ordinal(6)] 
		[RED("depotPath")] 
		public CString DepotPath
		{
			get => GetProperty(ref _depotPath);
			set => SetProperty(ref _depotPath, value);
		}

		[Ordinal(7)] 
		[RED("maskDumpFilePath")] 
		public AbsolutePathSerializable MaskDumpFilePath
		{
			get => GetProperty(ref _maskDumpFilePath);
			set => SetProperty(ref _maskDumpFilePath, value);
		}

		[Ordinal(8)] 
		[RED("exportMaterials")] 
		public CBool ExportMaterials
		{
			get => GetProperty(ref _exportMaterials);
			set => SetProperty(ref _exportMaterials, value);
		}

		[Ordinal(9)] 
		[RED("hjobToken")] 
		public CString HjobToken
		{
			get => GetProperty(ref _hjobToken);
			set => SetProperty(ref _hjobToken, value);
		}

		[Ordinal(10)] 
		[RED("hjobParams")] 
		public CString HjobParams
		{
			get => GetProperty(ref _hjobParams);
			set => SetProperty(ref _hjobParams, value);
		}

		[Ordinal(11)] 
		[RED("hjobParamsOutput")] 
		public CString HjobParamsOutput
		{
			get => GetProperty(ref _hjobParamsOutput);
			set => SetProperty(ref _hjobParamsOutput, value);
		}

		[Ordinal(12)] 
		[RED("assetName")] 
		public CString AssetName
		{
			get => GetProperty(ref _assetName);
			set => SetProperty(ref _assetName, value);
		}

		[Ordinal(13)] 
		[RED("rigs")] 
		public CString Rigs
		{
			get => GetProperty(ref _rigs);
			set => SetProperty(ref _rigs, value);
		}

		[Ordinal(14)] 
		[RED("hjobTemplate")] 
		public CString HjobTemplate
		{
			get => GetProperty(ref _hjobTemplate);
			set => SetProperty(ref _hjobTemplate, value);
		}

		[Ordinal(15)] 
		[RED("bodyType")] 
		public CString BodyType
		{
			get => GetProperty(ref _bodyType);
			set => SetProperty(ref _bodyType, value);
		}

		[Ordinal(16)] 
		[RED("baseType")] 
		public CString BaseType
		{
			get => GetProperty(ref _baseType);
			set => SetProperty(ref _baseType, value);
		}

		[Ordinal(17)] 
		[RED("exportBounds")] 
		public Box ExportBounds
		{
			get => GetProperty(ref _exportBounds);
			set => SetProperty(ref _exportBounds, value);
		}

		[Ordinal(18)] 
		[RED("referencePoint")] 
		public Vector3 ReferencePoint
		{
			get => GetProperty(ref _referencePoint);
			set => SetProperty(ref _referencePoint, value);
		}

		[Ordinal(19)] 
		[RED("assetPaths")] 
		public CArray<CString> AssetPaths
		{
			get => GetProperty(ref _assetPaths);
			set => SetProperty(ref _assetPaths, value);
		}

		[Ordinal(20)] 
		[RED("jsonFile")] 
		public AbsolutePathSerializable JsonFile
		{
			get => GetProperty(ref _jsonFile);
			set => SetProperty(ref _jsonFile, value);
		}

		[Ordinal(21)] 
		[RED("prefabType")] 
		public CUInt8 PrefabType
		{
			get => GetProperty(ref _prefabType);
			set => SetProperty(ref _prefabType, value);
		}

		[Ordinal(22)] 
		[RED("proxyFromProxy")] 
		public CBool ProxyFromProxy
		{
			get => GetProperty(ref _proxyFromProxy);
			set => SetProperty(ref _proxyFromProxy, value);
		}

		[Ordinal(23)] 
		[RED("onlyProxy")] 
		public CBool OnlyProxy
		{
			get => GetProperty(ref _onlyProxy);
			set => SetProperty(ref _onlyProxy, value);
		}

		[Ordinal(24)] 
		[RED("exportTextures")] 
		public CBool ExportTextures
		{
			get => GetProperty(ref _exportTextures);
			set => SetProperty(ref _exportTextures, value);
		}

		[Ordinal(25)] 
		[RED("minBBoxDiag")] 
		public CDouble MinBBoxDiag
		{
			get => GetProperty(ref _minBBoxDiag);
			set => SetProperty(ref _minBBoxDiag, value);
		}

		[Ordinal(26)] 
		[RED("asBBoxThreshold")] 
		public CDouble AsBBoxThreshold
		{
			get => GetProperty(ref _asBBoxThreshold);
			set => SetProperty(ref _asBBoxThreshold, value);
		}

		[Ordinal(27)] 
		[RED("asBBoxPrefabsThreshold")] 
		public CDouble AsBBoxPrefabsThreshold
		{
			get => GetProperty(ref _asBBoxPrefabsThreshold);
			set => SetProperty(ref _asBBoxPrefabsThreshold, value);
		}

		[Ordinal(28)] 
		[RED("asBBoxPrefabsSubdivide")] 
		public CDouble AsBBoxPrefabsSubdivide
		{
			get => GetProperty(ref _asBBoxPrefabsSubdivide);
			set => SetProperty(ref _asBBoxPrefabsSubdivide, value);
		}

		[Ordinal(29)] 
		[RED("asBBoxPrefabsForceLast")] 
		public CBool AsBBoxPrefabsForceLast
		{
			get => GetProperty(ref _asBBoxPrefabsForceLast);
			set => SetProperty(ref _asBBoxPrefabsForceLast, value);
		}

		[Ordinal(30)] 
		[RED("skipCollisions")] 
		public CBool SkipCollisions
		{
			get => GetProperty(ref _skipCollisions);
			set => SetProperty(ref _skipCollisions, value);
		}

		[Ordinal(31)] 
		[RED("preferSmallProxiesTreshold")] 
		public CFloat PreferSmallProxiesTreshold
		{
			get => GetProperty(ref _preferSmallProxiesTreshold);
			set => SetProperty(ref _preferSmallProxiesTreshold, value);
		}

		[Ordinal(32)] 
		[RED("generatePlayerBlockingCollision")] 
		public CBool GeneratePlayerBlockingCollision
		{
			get => GetProperty(ref _generatePlayerBlockingCollision);
			set => SetProperty(ref _generatePlayerBlockingCollision, value);
		}

		public interopReExportOptions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
