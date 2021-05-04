using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Potion_Blizzard : CBaseGameplayEffect
	{
		[Ordinal(1)] [RED("slowdownCauserIds", 2,0)] 		public CArray<CInt32> SlowdownCauserIds { get; set;}

		[Ordinal(2)] [RED("slowdownFactor")] 		public CFloat SlowdownFactor { get; set;}

		[Ordinal(3)] [RED("currentSlowMoDuration")] 		public CFloat CurrentSlowMoDuration { get; set;}

		[Ordinal(4)] [RED("SLOW_MO_DURATION")] 		public CFloat SLOW_MO_DURATION { get; set;}

		public W3Potion_Blizzard(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}