using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWraithSummonDoppelgangerDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(1)] [RED("entityToSummonName")] 		public CName EntityToSummonName { get; set;}

		[Ordinal(2)] [RED("entityToSummon")] 		public CName EntityToSummon { get; set;}

		[Ordinal(3)] [RED("splitEffectEntityTemplate")] 		public CHandle<CEntityTemplate> SplitEffectEntityTemplate { get; set;}

		[Ordinal(4)] [RED("summonOnAnimEvent")] 		public CName SummonOnAnimEvent { get; set;}

		[Ordinal(5)] [RED("numberToSummon")] 		public CInt32 NumberToSummon { get; set;}

		[Ordinal(6)] [RED("summonPositionPattern")] 		public CEnum<ESpawnPositionPattern> SummonPositionPattern { get; set;}

		[Ordinal(7)] [RED("summonMaxDistance")] 		public CFloat SummonMaxDistance { get; set;}

		[Ordinal(8)] [RED("summonMinDistance")] 		public CFloat SummonMinDistance { get; set;}

		[Ordinal(9)] [RED("applyBlindnessRange")] 		public CFloat ApplyBlindnessRange { get; set;}

		public CBTTaskWraithSummonDoppelgangerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskWraithSummonDoppelgangerDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}