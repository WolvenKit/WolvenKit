using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHitBasedNPC : CNewNPC
	{
		[Ordinal(1)] [RED("hitsToDeath")] 		public CInt32 HitsToDeath { get; set;}

		[Ordinal(2)] [RED("minTimeBetweenHits")] 		public CFloat MinTimeBetweenHits { get; set;}

		[Ordinal(3)] [RED("baseStat")] 		public CEnum<EBaseCharacterStats> BaseStat { get; set;}

		[Ordinal(4)] [RED("chunkValue")] 		public CFloat ChunkValue { get; set;}

		[Ordinal(5)] [RED("hitsTaken")] 		public CInt32 HitsTaken { get; set;}

		[Ordinal(6)] [RED("lastHitTimestamp")] 		public CFloat LastHitTimestamp { get; set;}

		[Ordinal(7)] [RED("wasInitialized")] 		public CBool WasInitialized { get; set;}

		public CHitBasedNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CHitBasedNPC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}