using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGwintMinigame : CMinigame
	{
		[RED("deckName")] 		public CName DeckName { get; set;}

		[RED("difficulty")] 		public EGwintDifficultyMode Difficulty { get; set;}

		[RED("aggression")] 		public EGwintAggressionMode Aggression { get; set;}

		[RED("allowMultipleMatches")] 		public CBool AllowMultipleMatches { get; set;}

		[RED("forceFaction")] 		public eGwintFaction ForceFaction { get; set;}

		public CGwintMinigame(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CGwintMinigame(cr2w);

	}
}