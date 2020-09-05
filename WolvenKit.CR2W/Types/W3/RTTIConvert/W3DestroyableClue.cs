using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3DestroyableClue : W3MonsterClue
	{
		[Ordinal(1)] [RED("destroyable")] 		public CBool Destroyable { get; set;}

		[Ordinal(2)] [RED("reactsToAard")] 		public CBool ReactsToAard { get; set;}

		[Ordinal(3)] [RED("reactsToIgni")] 		public CBool ReactsToIgni { get; set;}

		[Ordinal(4)] [RED("reactsToSwords")] 		public CBool ReactsToSwords { get; set;}

		[Ordinal(5)] [RED("reactsToBolts")] 		public CBool ReactsToBolts { get; set;}

		[Ordinal(6)] [RED("reactsToBombs")] 		public CBool ReactsToBombs { get; set;}

		[Ordinal(7)] [RED("defaultEffect")] 		public CName DefaultEffect { get; set;}

		[Ordinal(8)] [RED("effectOnReaction")] 		public CName EffectOnReaction { get; set;}

		[Ordinal(9)] [RED("effectOnBurning")] 		public CName EffectOnBurning { get; set;}

		[Ordinal(10)] [RED("effectInstant")] 		public CBool EffectInstant { get; set;}

		[Ordinal(11)] [RED("reactionDelay")] 		public CFloat ReactionDelay { get; set;}

		[Ordinal(12)] [RED("onDestroyedFact", 2,0)] 		public CArray<CString> OnDestroyedFact { get; set;}

		[Ordinal(13)] [RED("performDestructionSystemCheck")] 		public CBool PerformDestructionSystemCheck { get; set;}

		[Ordinal(14)] [RED("isBurning")] 		public CBool IsBurning { get; set;}

		[Ordinal(15)] [RED("destroyed")] 		public CBool Destroyed { get; set;}

		public W3DestroyableClue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DestroyableClue(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}