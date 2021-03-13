using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopReExportOptions : CVariable
	{
		[Ordinal(0)] [RED("occlusionExportOptNames")] public CArray<CName> OcclusionExportOptNames { get; set; }
		[Ordinal(1)] [RED("occlusionExportOptValues")] public CArray<CBool> OcclusionExportOptValues { get; set; }
		[Ordinal(2)] [RED("typeExportOptions")] public CArray<CBool> TypeExportOptions { get; set; }
		[Ordinal(3)] [RED("filePath")] public CString FilePath { get; set; }
		[Ordinal(4)] [RED("runDispatcher")] public CBool RunDispatcher { get; set; }
		[Ordinal(5)] [RED("files")] public CArray<CString> Files { get; set; }
		[Ordinal(6)] [RED("depotPath")] public CString DepotPath { get; set; }
		[Ordinal(7)] [RED("maskDumpFilePath")] public AbsolutePathSerializable MaskDumpFilePath { get; set; }
		[Ordinal(8)] [RED("exportMaterials")] public CBool ExportMaterials { get; set; }
		[Ordinal(9)] [RED("hjobToken")] public CString HjobToken { get; set; }
		[Ordinal(10)] [RED("hjobParams")] public CString HjobParams { get; set; }
		[Ordinal(11)] [RED("hjobParamsOutput")] public CString HjobParamsOutput { get; set; }
		[Ordinal(12)] [RED("assetName")] public CString AssetName { get; set; }
		[Ordinal(13)] [RED("rigs")] public CString Rigs { get; set; }
		[Ordinal(14)] [RED("hjobTemplate")] public CString HjobTemplate { get; set; }
		[Ordinal(15)] [RED("bodyType")] public CString BodyType { get; set; }
		[Ordinal(16)] [RED("baseType")] public CString BaseType { get; set; }
		[Ordinal(17)] [RED("exportBounds")] public Box ExportBounds { get; set; }
		[Ordinal(18)] [RED("referencePoint")] public Vector3 ReferencePoint { get; set; }
		[Ordinal(19)] [RED("assetPaths")] public CArray<CString> AssetPaths { get; set; }
		[Ordinal(20)] [RED("jsonFile")] public AbsolutePathSerializable JsonFile { get; set; }
		[Ordinal(21)] [RED("prefabType")] public CUInt8 PrefabType { get; set; }
		[Ordinal(22)] [RED("proxyFromProxy")] public CBool ProxyFromProxy { get; set; }
		[Ordinal(23)] [RED("onlyProxy")] public CBool OnlyProxy { get; set; }
		[Ordinal(24)] [RED("exportTextures")] public CBool ExportTextures { get; set; }
		[Ordinal(25)] [RED("minBBoxDiag")] public CDouble MinBBoxDiag { get; set; }
		[Ordinal(26)] [RED("asBBoxThreshold")] public CDouble AsBBoxThreshold { get; set; }
		[Ordinal(27)] [RED("asBBoxPrefabsThreshold")] public CDouble AsBBoxPrefabsThreshold { get; set; }
		[Ordinal(28)] [RED("asBBoxPrefabsSubdivide")] public CDouble AsBBoxPrefabsSubdivide { get; set; }
		[Ordinal(29)] [RED("asBBoxPrefabsForceLast")] public CBool AsBBoxPrefabsForceLast { get; set; }
		[Ordinal(30)] [RED("skipCollisions")] public CBool SkipCollisions { get; set; }
		[Ordinal(31)] [RED("preferSmallProxiesTreshold")] public CFloat PreferSmallProxiesTreshold { get; set; }

		public interopReExportOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
