using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldNodeEditorData : ISerializable
	{
		[Ordinal(0)]  [RED("alternativeGlobalName")] public CString AlternativeGlobalName { get; set; }
		[Ordinal(1)]  [RED("excludeOnConsole")] public CBool ExcludeOnConsole { get; set; }
		[Ordinal(2)]  [RED("globalName")] public CString GlobalName { get; set; }
		[Ordinal(3)]  [RED("id")] public CUInt64 Id { get; set; }
		[Ordinal(4)]  [RED("isAlternativeGlobalNameLocked")] public CBool IsAlternativeGlobalNameLocked { get; set; }
		[Ordinal(5)]  [RED("isDestructibleNode")] public CBool IsDestructibleNode { get; set; }
		[Ordinal(6)]  [RED("isDiscarded")] public CBool IsDiscarded { get; set; }
		[Ordinal(7)]  [RED("isGlobalNameLocked")] public CBool IsGlobalNameLocked { get; set; }
		[Ordinal(8)]  [RED("isInterior")] public CBool IsInterior { get; set; }
		[Ordinal(9)]  [RED("isSnapSource")] public CBool IsSnapSource { get; set; }
		[Ordinal(10)]  [RED("isSnapTarget")] public CBool IsSnapTarget { get; set; }
		[Ordinal(11)]  [RED("maxStreamingDistance")] public CFloat MaxStreamingDistance { get; set; }
		[Ordinal(12)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(13)]  [RED("pivotTransform")] public Transform PivotTransform { get; set; }
		[Ordinal(14)]  [RED("proxyMeshDependency")] public CEnum<worldProxyMeshDependencyMode> ProxyMeshDependency { get; set; }
		[Ordinal(15)]  [RED("questPrefabRefHash")] public CUInt64 QuestPrefabRefHash { get; set; }
		[Ordinal(16)]  [RED("transform")] public worldNodeTransform Transform { get; set; }
		[Ordinal(17)]  [RED("variantId")] public CUInt32 VariantId { get; set; }

		public worldNodeEditorData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
