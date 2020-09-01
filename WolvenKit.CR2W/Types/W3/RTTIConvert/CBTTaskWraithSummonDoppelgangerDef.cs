using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWraithSummonDoppelgangerDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(0)] [RED("("entityToSummonName")] 		public CName EntityToSummonName { get; set;}

		[Ordinal(0)] [RED("("entityToSummon")] 		public CName EntityToSummon { get; set;}

		[Ordinal(0)] [RED("("splitEffectEntityTemplate")] 		public CHandle<CEntityTemplate> SplitEffectEntityTemplate { get; set;}

		[Ordinal(0)] [RED("("summonOnAnimEvent")] 		public CName SummonOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("numberToSummon")] 		public CInt32 NumberToSummon { get; set;}

		[Ordinal(0)] [RED("("summonPositionPattern")] 		public CEnum<ESpawnPositionPattern> SummonPositionPattern { get; set;}

		[Ordinal(0)] [RED("("summonMaxDistance")] 		public CFloat SummonMaxDistance { get; set;}

		[Ordinal(0)] [RED("("summonMinDistance")] 		public CFloat SummonMinDistance { get; set;}

		[Ordinal(0)] [RED("("applyBlindnessRange")] 		public CFloat ApplyBlindnessRange { get; set;}

		public CBTTaskWraithSummonDoppelgangerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskWraithSummonDoppelgangerDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}