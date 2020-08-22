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
		[RED("skateGlobal")] 		public CHandle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

		[RED("impulse")] 		public CFloat Impulse { get; set;}

		[RED("timeMax")] 		public CFloat TimeMax { get; set;}

		[RED("timeToChainMin")] 		public CFloat TimeToChainMin { get; set;}

		[RED("sharpTurnSpeed")] 		public CFloat SharpTurnSpeed { get; set;}

		[RED("holdTurnSpeed")] 		public CFloat HoldTurnSpeed { get; set;}

		[RED("sharpTurn")] 		public CBool SharpTurn { get; set;}

		[RED("sharpTurnTime")] 		public CFloat SharpTurnTime { get; set;}

		[RED("behAttackEvent")] 		public CName BehAttackEvent { get; set;}

		[RED("behLeftFootParam")] 		public CName BehLeftFootParam { get; set;}

		[RED("boneRightFoot")] 		public CName BoneRightFoot { get; set;}

		[RED("boneLeftFoot")] 		public CName BoneLeftFoot { get; set;}

		[RED("boneIndexRightFoot")] 		public CInt32 BoneIndexRightFoot { get; set;}

		[RED("boneIndexLeftFoot")] 		public CInt32 BoneIndexLeftFoot { get; set;}

		[RED("behEventEnd")] 		public CName BehEventEnd { get; set;}

		public CExplorationStateSkatingDash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSkatingDash(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}