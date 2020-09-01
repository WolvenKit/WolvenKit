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
		[Ordinal(0)] [RED("("destroyable")] 		public CBool Destroyable { get; set;}

		[Ordinal(0)] [RED("("reactsToAard")] 		public CBool ReactsToAard { get; set;}

		[Ordinal(0)] [RED("("reactsToIgni")] 		public CBool ReactsToIgni { get; set;}

		[Ordinal(0)] [RED("("reactsToSwords")] 		public CBool ReactsToSwords { get; set;}

		[Ordinal(0)] [RED("("reactsToBolts")] 		public CBool ReactsToBolts { get; set;}

		[Ordinal(0)] [RED("("reactsToBombs")] 		public CBool ReactsToBombs { get; set;}

		[Ordinal(0)] [RED("("defaultEffect")] 		public CName DefaultEffect { get; set;}

		[Ordinal(0)] [RED("("effectOnReaction")] 		public CName EffectOnReaction { get; set;}

		[Ordinal(0)] [RED("("effectOnBurning")] 		public CName EffectOnBurning { get; set;}

		[Ordinal(0)] [RED("("effectInstant")] 		public CBool EffectInstant { get; set;}

		[Ordinal(0)] [RED("("reactionDelay")] 		public CFloat ReactionDelay { get; set;}

		[Ordinal(0)] [RED("("onDestroyedFact", 2,0)] 		public CArray<CString> OnDestroyedFact { get; set;}

		[Ordinal(0)] [RED("("performDestructionSystemCheck")] 		public CBool PerformDestructionSystemCheck { get; set;}

		[Ordinal(0)] [RED("("isBurning")] 		public CBool IsBurning { get; set;}

		[Ordinal(0)] [RED("("destroyed")] 		public CBool Destroyed { get; set;}

		public W3DestroyableClue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DestroyableClue(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}