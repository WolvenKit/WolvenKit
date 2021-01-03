using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnSpawnDespawnEntityParams : CVariable
	{
		[Ordinal(0)]  [RED("alwaysSpawned")] public CBool AlwaysSpawned { get; set; }
		[Ordinal(1)]  [RED("appearance")] public CName Appearance { get; set; }
		[Ordinal(2)]  [RED("dynamicEntityUniqueName")] public CName DynamicEntityUniqueName { get; set; }
		[Ordinal(3)]  [RED("findInWorld")] public CBool FindInWorld { get; set; }
		[Ordinal(4)]  [RED("forceMaxVisibility")] public CBool ForceMaxVisibility { get; set; }
		[Ordinal(5)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(6)]  [RED("itemOwnerId")] public scnPerformerId ItemOwnerId { get; set; }
		[Ordinal(7)]  [RED("keepAlive")] public CBool KeepAlive { get; set; }
		[Ordinal(8)]  [RED("prefetchAppearance")] public CBool PrefetchAppearance { get; set; }
		[Ordinal(9)]  [RED("spawnMarker")] public CName SpawnMarker { get; set; }
		[Ordinal(10)]  [RED("spawnMarkerNodeRef")] public NodeRef SpawnMarkerNodeRef { get; set; }
		[Ordinal(11)]  [RED("spawnMarkerType")] public CEnum<scnMarkerType> SpawnMarkerType { get; set; }
		[Ordinal(12)]  [RED("spawnOffset")] public Transform SpawnOffset { get; set; }
		[Ordinal(13)]  [RED("spawnOnStart")] public CBool SpawnOnStart { get; set; }
		[Ordinal(14)]  [RED("specRecordId")] public TweakDBID SpecRecordId { get; set; }
		[Ordinal(15)]  [RED("validateSpawnPostion")] public CBool ValidateSpawnPostion { get; set; }

		public scnSpawnDespawnEntityParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
