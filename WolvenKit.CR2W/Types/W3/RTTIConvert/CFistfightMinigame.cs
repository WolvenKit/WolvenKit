using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFistfightMinigame : CMinigame
	{
		[Ordinal(1)] [RED("fightAreaTag")] 		public CName FightAreaTag { get; set;}

		[Ordinal(2)] [RED("playerPosTag")] 		public CName PlayerPosTag { get; set;}

		[Ordinal(3)] [RED("toTheDeath")] 		public CBool ToTheDeath { get; set;}

		[Ordinal(4)] [RED("endsWithBlackscreen")] 		public CBool EndsWithBlackscreen { get; set;}

		[Ordinal(5)] [RED("enemies", 2,0)] 		public CArray<CFistfightOpponent> Enemies { get; set;}

		public CFistfightMinigame(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFistfightMinigame(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}