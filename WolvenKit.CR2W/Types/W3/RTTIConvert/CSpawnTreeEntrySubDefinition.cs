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

		public CSpawnTreeEntrySubDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSpawnTreeEntrySubDefinition(cr2w);

	}
}