using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestFastForwardCommunitiesBlock : CQuestGraphBlock
	{
		[Ordinal(0)] [RED("manageBlackscreen")] 		public CBool ManageBlackscreen { get; set;}

		[Ordinal(0)] [RED("respawnEveryone")] 		public CBool RespawnEveryone { get; set;}

		[Ordinal(0)] [RED("dontSpawnHostilesClose")] 		public CBool DontSpawnHostilesClose { get; set;}

		[Ordinal(0)] [RED("timeLimit")] 		public CFloat TimeLimit { get; set;}

		public CQuestFastForwardCommunitiesBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestFastForwardCommunitiesBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}