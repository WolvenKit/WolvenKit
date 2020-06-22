using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeEntrySubDefinition : CObject
	{
		[RED("id")] 		public CUInt64 Id { get; set;}

		[RED("creatureDefinition")] 		public CName CreatureDefinition { get; set;}

		[RED("partyMemberId")] 		public CName PartyMemberId { get; set;}

		[RED("creatureCount")] 		public CUInt32 CreatureCount { get; set;}

		[RED("initializers", 2,0)] 		public CArray<CPtr<ISpawnTreeInitializer>> Initializers { get; set;}

		[RED("graphPosX")] 		public CInt32 GraphPosX { get; set;}

		[RED("graphPosY")] 		public CInt32 GraphPosY { get; set;}

		[RED("comment")] 		public CString Comment { get; set;}

		public CSpawnTreeEntrySubDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSpawnTreeEntrySubDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}