using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MonsterHuntInvestigationArea : CGameplayEntity
	{
		[Ordinal(1)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(2)] [RED("investigationMusicStartEvent")] 		public CString InvestigationMusicStartEvent { get; set;}

		[Ordinal(3)] [RED("investigationMusicStopEvent")] 		public CString InvestigationMusicStopEvent { get; set;}

		[Ordinal(4)] [RED("requiredTrackedQuest")] 		public CName RequiredTrackedQuest { get; set;}

		[Ordinal(5)] [RED("active")] 		public CBool Active { get; set;}

		public W3MonsterHuntInvestigationArea(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}