using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskGuard : IBehTreeTask
	{
		[Ordinal(1)] [RED("guardArea")] 		public CHandle<CAreaComponent> GuardArea { get; set;}

		[Ordinal(2)] [RED("pursuitArea")] 		public CHandle<CAreaComponent> PursuitArea { get; set;}

		[Ordinal(3)] [RED("pursuitRange")] 		public CFloat PursuitRange { get; set;}

		[Ordinal(4)] [RED("retreatType")] 		public CEnum<EMoveType> RetreatType { get; set;}

		[Ordinal(5)] [RED("retreatSpeed")] 		public CFloat RetreatSpeed { get; set;}

		[Ordinal(6)] [RED("intruderTestFrequency")] 		public CFloat IntruderTestFrequency { get; set;}

		[Ordinal(7)] [RED("intruderTestTimeout")] 		public CFloat IntruderTestTimeout { get; set;}

		[Ordinal(8)] [RED("guardState")] 		public CEnum<EGuardState> GuardState { get; set;}

		[Ordinal(9)] [RED("intruders", 2,0)] 		public CArray<CHandle<CGameplayEntity>> Intruders { get; set;}

		[Ordinal(10)] [RED("target")] 		public CHandle<CActor> Target { get; set;}

		public CBTTaskGuard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskGuard(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}