using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeEntrySubDefinition : CObject
	{
		[Ordinal(0)] [RED("id")] 		public CUInt64 Id { get; set;}

		[Ordinal(0)] [RED("creatureDefinition")] 		public CName CreatureDefinition { get; set;}

		[Ordinal(0)] [RED("partyMemberId")] 		public CName PartyMemberId { get; set;}

		[Ordinal(0)] [RED("creatureCount")] 		public CUInt32 CreatureCount { get; set;}

		[Ordinal(0)] [RED("initializers", 2,0)] 		public CArray<CPtr<ISpawnTreeInitializer>> Initializers { get; set;}

		[Ordinal(0)] [RED("graphPosX")] 		public CInt32 GraphPosX { get; set;}

		[Ordinal(0)] [RED("graphPosY")] 		public CInt32 GraphPosY { get; set;}

		[Ordinal(0)] [RED("comment")] 		public CString Comment { get; set;}

		public CSpawnTreeEntrySubDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSpawnTreeEntrySubDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}