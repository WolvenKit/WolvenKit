using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingDash : CExplorationStateAbstract
	{
		[Ordinal(0)] [RED("("skateGlobal")] 		public CHandle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

		[Ordinal(0)] [RED("("impulse")] 		public CFloat Impulse { get; set;}

		[Ordinal(0)] [RED("("timeMax")] 		public CFloat TimeMax { get; set;}

		[Ordinal(0)] [RED("("timeToChainMin")] 		public CFloat TimeToChainMin { get; set;}

		[Ordinal(0)] [RED("("sharpTurnSpeed")] 		public CFloat SharpTurnSpeed { get; set;}

		[Ordinal(0)] [RED("("holdTurnSpeed")] 		public CFloat HoldTurnSpeed { get; set;}

		[Ordinal(0)] [RED("("sharpTurn")] 		public CBool SharpTurn { get; set;}

		[Ordinal(0)] [RED("("sharpTurnTime")] 		public CFloat SharpTurnTime { get; set;}

		[Ordinal(0)] [RED("("behAttackEvent")] 		public CName BehAttackEvent { get; set;}

		[Ordinal(0)] [RED("("behLeftFootParam")] 		public CName BehLeftFootParam { get; set;}

		[Ordinal(0)] [RED("("boneRightFoot")] 		public CName BoneRightFoot { get; set;}

		[Ordinal(0)] [RED("("boneLeftFoot")] 		public CName BoneLeftFoot { get; set;}

		[Ordinal(0)] [RED("("boneIndexRightFoot")] 		public CInt32 BoneIndexRightFoot { get; set;}

		[Ordinal(0)] [RED("("boneIndexLeftFoot")] 		public CInt32 BoneIndexLeftFoot { get; set;}

		[Ordinal(0)] [RED("("behEventEnd")] 		public CName BehEventEnd { get; set;}

		public CExplorationStateSkatingDash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSkatingDash(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}