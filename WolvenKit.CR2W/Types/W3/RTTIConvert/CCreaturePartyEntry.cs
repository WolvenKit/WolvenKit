using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCreaturePartyEntry : CBaseCreatureEntry
	{
		[RED("subDefinitions", 2,0)] 		public CArray<CPtr<CSpawnTreeEntrySubDefinition>> SubDefinitions { get; set;}

		[RED("partySpawnOrganizer")] 		public CHandle<CPartySpawnOrganizer> PartySpawnOrganizer { get; set;}

		[RED("blockChats")] 		public CBool BlockChats { get; set;}

		[RED("synchronizeWork")] 		public CBool SynchronizeWork { get; set;}

		public CCreaturePartyEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCreaturePartyEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}