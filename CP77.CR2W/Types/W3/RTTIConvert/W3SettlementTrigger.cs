using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SettlementTrigger : CR4JournalPlaceEntity
	{
		[Ordinal(1)] [RED("bDisplaySettlementInfo")] 		public CBool BDisplaySettlementInfo { get; set;}

		[Ordinal(2)] [RED("settlementName")] 		public CName SettlementName { get; set;}

		[Ordinal(3)] [RED("hubNameOverride")] 		public CName HubNameOverride { get; set;}

		[Ordinal(4)] [RED("lockReenterDisplayTime")] 		public CFloat LockReenterDisplayTime { get; set;}

		[Ordinal(5)] [RED("blockHorseTopSpeed")] 		public CBool BlockHorseTopSpeed { get; set;}

		public W3SettlementTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SettlementTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}