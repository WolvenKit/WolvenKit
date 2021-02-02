using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class appearanceAppearanceResource : resStreamedResource
	{
		[Ordinal(0)]  [RED("baseType")] public CName BaseType { get; set; }
		[Ordinal(1)]  [RED("baseEntityType")] public CName BaseEntityType { get; set; }
		[Ordinal(2)]  [RED("partType")] public CName PartType { get; set; }
		[Ordinal(3)]  [RED("preset")] public CName Preset { get; set; }
		[Ordinal(4)]  [RED("proxyPolyCount")] public CInt32 ProxyPolyCount { get; set; }
		[Ordinal(5)]  [RED("forceCompileProxy")] public CBool ForceCompileProxy { get; set; }
		[Ordinal(6)]  [RED("baseEntity")] public raRef<entEntityTemplate> BaseEntity { get; set; }
		[Ordinal(7)]  [RED("appearances")] public CArray<CHandle<appearanceAppearanceDefinition>> Appearances { get; set; }
		[Ordinal(8)]  [RED("censorshipMapping")] public CArray<appearanceCensorshipEntry> CensorshipMapping { get; set; }
		[Ordinal(9)]  [RED("commonCookData")] public raRef<appearanceCookedAppearanceData> CommonCookData { get; set; }
		[Ordinal(10)]  [RED("Wounds")] public CArray<CHandle<entdismembermentWoundResource>> Wounds { get; set; }
		[Ordinal(11)]  [RED("DismEffects")] public CArray<CHandle<entdismembermentEffectResource>> DismEffects { get; set; }
		[Ordinal(12)]  [RED("DismWoundConfig")] public entdismembermentWoundsConfigSet DismWoundConfig { get; set; }

		public appearanceAppearanceResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
