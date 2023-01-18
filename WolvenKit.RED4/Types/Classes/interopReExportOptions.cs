using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopReExportOptions : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("occlusionExportOptNames")] 
		public CArray<CName> OcclusionExportOptNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("occlusionExportOptValues")] 
		public CArray<CBool> OcclusionExportOptValues
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(2)] 
		[RED("typeExportOptions")] 
		public CArray<CBool> TypeExportOptions
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(3)] 
		[RED("filePath")] 
		public CString FilePath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("runDispatcher")] 
		public CBool RunDispatcher
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("files")] 
		public CArray<CString> Files
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(6)] 
		[RED("depotPath")] 
		public CString DepotPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("maskDumpFilePath")] 
		public AbsolutePathSerializable MaskDumpFilePath
		{
			get => GetPropertyValue<AbsolutePathSerializable>();
			set => SetPropertyValue<AbsolutePathSerializable>(value);
		}

		[Ordinal(8)] 
		[RED("exportMaterials")] 
		public CBool ExportMaterials
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("hjobToken")] 
		public CString HjobToken
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("hjobParams")] 
		public CString HjobParams
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("hjobParamsOutput")] 
		public CString HjobParamsOutput
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(12)] 
		[RED("assetName")] 
		public CString AssetName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(13)] 
		[RED("rigs")] 
		public CString Rigs
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(14)] 
		[RED("hjobTemplate")] 
		public CString HjobTemplate
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(15)] 
		[RED("bodyType")] 
		public CString BodyType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(16)] 
		[RED("baseType")] 
		public CString BaseType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(17)] 
		[RED("exportBounds")] 
		public Box ExportBounds
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(18)] 
		[RED("referencePoint")] 
		public Vector3 ReferencePoint
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(19)] 
		[RED("assetPaths")] 
		public CArray<CString> AssetPaths
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(20)] 
		[RED("jsonFile")] 
		public AbsolutePathSerializable JsonFile
		{
			get => GetPropertyValue<AbsolutePathSerializable>();
			set => SetPropertyValue<AbsolutePathSerializable>(value);
		}

		[Ordinal(21)] 
		[RED("prefabType")] 
		public CUInt8 PrefabType
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(22)] 
		[RED("proxyFromProxy")] 
		public CBool ProxyFromProxy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("onlyProxy")] 
		public CBool OnlyProxy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("exportTextures")] 
		public CBool ExportTextures
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("minBBoxDiag")] 
		public CDouble MinBBoxDiag
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(26)] 
		[RED("asBBoxThreshold")] 
		public CDouble AsBBoxThreshold
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(27)] 
		[RED("asBBoxPrefabsThreshold")] 
		public CDouble AsBBoxPrefabsThreshold
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(28)] 
		[RED("asBBoxPrefabsSubdivide")] 
		public CDouble AsBBoxPrefabsSubdivide
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(29)] 
		[RED("asBBoxPrefabsForceLast")] 
		public CBool AsBBoxPrefabsForceLast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("skipCollisions")] 
		public CBool SkipCollisions
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("preferSmallProxiesTreshold")] 
		public CFloat PreferSmallProxiesTreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("generatePlayerBlockingCollision")] 
		public CBool GeneratePlayerBlockingCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public interopReExportOptions()
		{
			OcclusionExportOptNames = new();
			OcclusionExportOptValues = new();
			TypeExportOptions = new();
			Files = new();
			MaskDumpFilePath = new();
			ExportMaterials = true;
			ExportBounds = new() { Min = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 340282346638528859811704183484516925440.000000F }, Max = new() { X = -340282346638528859811704183484516925440.000000F, Y = -340282346638528859811704183484516925440.000000F, Z = -340282346638528859811704183484516925440.000000F, W = -340282346638528859811704183484516925440.000000F } };
			ReferencePoint = new();
			AssetPaths = new();
			JsonFile = new();
			MinBBoxDiag = 0.000000;
			AsBBoxThreshold = 0.000000;
			AsBBoxPrefabsThreshold = 0.000000;
			AsBBoxPrefabsSubdivide = 0.000000;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
