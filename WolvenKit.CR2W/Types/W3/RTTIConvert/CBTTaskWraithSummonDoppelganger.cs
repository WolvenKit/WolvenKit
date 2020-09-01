using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWraithSummonDoppelganger : CBTTaskPlayAnimationEventDecorator
	{
		[Ordinal(1)] [RED("("splitEffectEntityTemplate")] 		public CHandle<CEntityTemplate> SplitEffectEntityTemplate { get; set;}

		[Ordinal(2)] [RED("("numberToSummon")] 		public CInt32 NumberToSummon { get; set;}

		[Ordinal(3)] [RED("("summonOnAnimEvent")] 		public CName SummonOnAnimEvent { get; set;}

		[Ordinal(4)] [RED("("summonPositionPattern")] 		public CEnum<ESpawnPositionPattern> SummonPositionPattern { get; set;}

		[Ordinal(5)] [RED("("summonMaxDistance")] 		public CFloat SummonMaxDistance { get; set;}

		[Ordinal(6)] [RED("("summonMinDistance")] 		public CFloat SummonMinDistance { get; set;}

		[Ordinal(7)] [RED("("entityToSummonName")] 		public CName EntityToSummonName { get; set;}

		[Ordinal(8)] [RED("("splitEffectEntity")] 		public CName SplitEffectEntity { get; set;}

		[Ordinal(9)] [RED("("applyBlindnessRange")] 		public CFloat ApplyBlindnessRange { get; set;}

		[Ordinal(10)] [RED("("entityToSummon")] 		public CHandle<CEntityTemplate> EntityToSummon { get; set;}

		[Ordinal(11)] [RED("("m_shouldSummon")] 		public CBool M_shouldSummon { get; set;}

		[Ordinal(12)] [RED("("m_hasSummoned")] 		public CBool M_hasSummoned { get; set;}

		[Ordinal(13)] [RED("("m_createEntityHelper")] 		public CHandle<CCreateEntityHelper> M_createEntityHelper { get; set;}

		public CBTTaskWraithSummonDoppelganger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskWraithSummonDoppelganger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}