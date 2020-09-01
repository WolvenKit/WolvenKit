using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFistfightMinigame : CMinigame
	{
		[Ordinal(0)] [RED("("fightAreaTag")] 		public CName FightAreaTag { get; set;}

		[Ordinal(0)] [RED("("playerPosTag")] 		public CName PlayerPosTag { get; set;}

		[Ordinal(0)] [RED("("toTheDeath")] 		public CBool ToTheDeath { get; set;}

		[Ordinal(0)] [RED("("endsWithBlackscreen")] 		public CBool EndsWithBlackscreen { get; set;}

		[Ordinal(0)] [RED("("enemies", 2,0)] 		public CArray<CFistfightOpponent> Enemies { get; set;}

		public CFistfightMinigame(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFistfightMinigame(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}