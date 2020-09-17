using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHeartMiniboss : CNewNPC
	{
		[Ordinal(1)] [RED("phasesCount")] 		public CInt32 PhasesCount { get; set;}

		[Ordinal(2)] [RED("currentPhase")] 		public CInt32 CurrentPhase { get; set;}

		[Ordinal(3)] [RED("essenceChunks")] 		public CInt32 EssenceChunks { get; set;}

		[Ordinal(4)] [RED("essenceChunkValue")] 		public CFloat EssenceChunkValue { get; set;}

		[Ordinal(5)] [RED("canHit")] 		public CBool CanHit { get; set;}

		[Ordinal(6)] [RED("valuesInitialised")] 		public CBool ValuesInitialised { get; set;}

		[Ordinal(7)] [RED("factSetAfterDeath")] 		public CString FactSetAfterDeath { get; set;}

		[Ordinal(8)] [RED("factSetInOpenedPhase")] 		public CString FactSetInOpenedPhase { get; set;}

		[Ordinal(9)] [RED("factSetInArmoredPhase")] 		public CString FactSetInArmoredPhase { get; set;}

		public CHeartMiniboss(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CHeartMiniboss(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}