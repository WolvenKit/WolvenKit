using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCommunity : CResource
	{
		[Ordinal(1)] [RED("communityTable", 2,0)] 		public CArray<CSTableEntry> CommunityTable { get; set;}

		[Ordinal(2)] [RED("storyPhaseTimetable", 2,0)] 		public CArray<CSStoryPhaseTimetableEntry> StoryPhaseTimetable { get; set;}

		[Ordinal(3)] [RED("spawnsetType")] 		public CEnum<ECommunitySpawnsetType> SpawnsetType { get; set;}

		public CCommunity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCommunity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}