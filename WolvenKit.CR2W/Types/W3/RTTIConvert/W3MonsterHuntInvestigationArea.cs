using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MonsterHuntInvestigationArea : CGameplayEntity
	{
		[Ordinal(1)] [RED("("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(2)] [RED("("investigationMusicStartEvent")] 		public CString InvestigationMusicStartEvent { get; set;}

		[Ordinal(3)] [RED("("investigationMusicStopEvent")] 		public CString InvestigationMusicStopEvent { get; set;}

		[Ordinal(4)] [RED("("requiredTrackedQuest")] 		public CName RequiredTrackedQuest { get; set;}

		[Ordinal(5)] [RED("("active")] 		public CBool Active { get; set;}

		public W3MonsterHuntInvestigationArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MonsterHuntInvestigationArea(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}