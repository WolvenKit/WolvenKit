using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFistfightMinigame : CMinigame
	{
		[RED("fightAreaTag")] 		public CName FightAreaTag { get; set;}

		[RED("playerPosTag")] 		public CName PlayerPosTag { get; set;}

		[RED("toTheDeath")] 		public CBool ToTheDeath { get; set;}

		[RED("endsWithBlackscreen")] 		public CBool EndsWithBlackscreen { get; set;}

		[RED("enemies", 2,0)] 		public CArray<CFistfightOpponent> Enemies { get; set;}

		public CFistfightMinigame(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CFistfightMinigame(cr2w);

	}
}