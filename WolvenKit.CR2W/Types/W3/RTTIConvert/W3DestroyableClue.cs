using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3DestroyableClue : W3MonsterClue
	{
		[RED("destroyable")] 		public CBool Destroyable { get; set;}

		[RED("reactsToAard")] 		public CBool ReactsToAard { get; set;}

		[RED("reactsToIgni")] 		public CBool ReactsToIgni { get; set;}

		[RED("reactsToSwords")] 		public CBool ReactsToSwords { get; set;}

		[RED("reactsToBolts")] 		public CBool ReactsToBolts { get; set;}

		[RED("reactsToBombs")] 		public CBool ReactsToBombs { get; set;}

		[RED("defaultEffect")] 		public CName DefaultEffect { get; set;}

		[RED("effectOnReaction")] 		public CName EffectOnReaction { get; set;}

		[RED("effectOnBurning")] 		public CName EffectOnBurning { get; set;}

		[RED("effectInstant")] 		public CBool EffectInstant { get; set;}

		[RED("reactionDelay")] 		public CFloat ReactionDelay { get; set;}

		[RED("onDestroyedFact", 2,0)] 		public CArray<CString> OnDestroyedFact { get; set;}

		[RED("performDestructionSystemCheck")] 		public CBool PerformDestructionSystemCheck { get; set;}

		[RED("isBurning")] 		public CBool IsBurning { get; set;}

		[RED("destroyed")] 		public CBool Destroyed { get; set;}

		public W3DestroyableClue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DestroyableClue(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}