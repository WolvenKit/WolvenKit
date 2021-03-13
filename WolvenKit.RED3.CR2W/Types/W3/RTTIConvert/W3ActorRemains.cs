using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ActorRemains : W3AnimatedContainer
	{
		[Ordinal(1)] [RED("dismemberOnLoot")] 		public CBool DismemberOnLoot { get; set;}

		[Ordinal(2)] [RED("dismembermentOnlyWhenLootingTrophy")] 		public CBool DismembermentOnlyWhenLootingTrophy { get; set;}

		[Ordinal(3)] [RED("dismembermentType")] 		public CEnum<EDismembermentWoundTypes> DismembermentType { get; set;}

		[Ordinal(4)] [RED("dismembermentName")] 		public CName DismembermentName { get; set;}

		[Ordinal(5)] [RED("manualTrophyTransfer")] 		public CBool ManualTrophyTransfer { get; set;}

		[Ordinal(6)] [RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[Ordinal(7)] [RED("hasTrophy")] 		public CBool HasTrophy { get; set;}

		[Ordinal(8)] [RED("wasDismembered")] 		public CBool WasDismembered { get; set;}

		[Ordinal(9)] [RED("trophyItemNames", 2,0)] 		public CArray<CName> TrophyItemNames { get; set;}

		public W3ActorRemains(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ActorRemains(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}