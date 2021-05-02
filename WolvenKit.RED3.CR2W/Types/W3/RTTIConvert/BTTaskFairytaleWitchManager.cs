using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskFairytaleWitchManager : IBehTreeTask
	{
		[Ordinal(1)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(2)] [RED("spawnedNpc")] 		public CHandle<CNewNPC> SpawnedNpc { get; set;}

		[Ordinal(3)] [RED("spawnedSecondNpc")] 		public CHandle<CNewNPC> SpawnedSecondNpc { get; set;}

		[Ordinal(4)] [RED("nodeTags", 2,0)] 		public CArray<CName> NodeTags { get; set;}

		[Ordinal(5)] [RED("resourceName", 2,0)] 		public CArray<CName> ResourceName { get; set;}

		[Ordinal(6)] [RED("initialSleepTime")] 		public CFloat InitialSleepTime { get; set;}

		[Ordinal(7)] [RED("firstNodeTag")] 		public CName FirstNodeTag { get; set;}

		[Ordinal(8)] [RED("secondNodeTag")] 		public CName SecondNodeTag { get; set;}

		[Ordinal(9)] [RED("thirdNodeTag")] 		public CName ThirdNodeTag { get; set;}

		[Ordinal(10)] [RED("finalNodeTag")] 		public CName FinalNodeTag { get; set;}

		[Ordinal(11)] [RED("archesporResource")] 		public CName ArchesporResource { get; set;}

		[Ordinal(12)] [RED("pantherResource")] 		public CName PantherResource { get; set;}

		public BTTaskFairytaleWitchManager(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskFairytaleWitchManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}