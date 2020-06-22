using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskFairytaleWitchManager : IBehTreeTask
	{
		[RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[RED("spawnedNpc")] 		public CHandle<CNewNPC> SpawnedNpc { get; set;}

		[RED("spawnedSecondNpc")] 		public CHandle<CNewNPC> SpawnedSecondNpc { get; set;}

		[RED("nodeTags", 2,0)] 		public CArray<CName> NodeTags { get; set;}

		[RED("resourceName", 2,0)] 		public CArray<CName> ResourceName { get; set;}

		[RED("initialSleepTime")] 		public CFloat InitialSleepTime { get; set;}

		[RED("firstNodeTag")] 		public CName FirstNodeTag { get; set;}

		[RED("secondNodeTag")] 		public CName SecondNodeTag { get; set;}

		[RED("thirdNodeTag")] 		public CName ThirdNodeTag { get; set;}

		[RED("finalNodeTag")] 		public CName FinalNodeTag { get; set;}

		[RED("archesporResource")] 		public CName ArchesporResource { get; set;}

		[RED("pantherResource")] 		public CName PantherResource { get; set;}

		public BTTaskFairytaleWitchManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskFairytaleWitchManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}