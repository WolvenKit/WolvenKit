using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWraithSummonDoppelgangerDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[RED("entityToSummonName")] 		public CName EntityToSummonName { get; set;}

		[RED("entityToSummon")] 		public CName EntityToSummon { get; set;}

		[RED("splitEffectEntityTemplate")] 		public CHandle<CEntityTemplate> SplitEffectEntityTemplate { get; set;}

		[RED("summonOnAnimEvent")] 		public CName SummonOnAnimEvent { get; set;}

		[RED("numberToSummon")] 		public CInt32 NumberToSummon { get; set;}

		[RED("summonPositionPattern")] 		public ESpawnPositionPattern SummonPositionPattern { get; set;}

		[RED("summonMaxDistance")] 		public CFloat SummonMaxDistance { get; set;}

		[RED("summonMinDistance")] 		public CFloat SummonMinDistance { get; set;}

		[RED("applyBlindnessRange")] 		public CFloat ApplyBlindnessRange { get; set;}

		public CBTTaskWraithSummonDoppelgangerDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskWraithSummonDoppelgangerDef(cr2w);

	}
}