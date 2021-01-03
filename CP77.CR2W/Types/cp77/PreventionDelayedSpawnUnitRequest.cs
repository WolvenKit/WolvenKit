using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PreventionDelayedSpawnUnitRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("preventionLevel")] public CUInt32 PreventionLevel { get; set; }
		[Ordinal(1)]  [RED("recordID")] public TweakDBID RecordID { get; set; }
		[Ordinal(2)]  [RED("spawnTransform")] public WorldTransform SpawnTransform { get; set; }

		public PreventionDelayedSpawnUnitRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
