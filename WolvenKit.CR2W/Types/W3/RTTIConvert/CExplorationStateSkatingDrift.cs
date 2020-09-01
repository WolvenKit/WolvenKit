using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingDrift : CExplorationStateAbstract
	{
		[Ordinal(0)] [RED("("skateGlobal")] 		public CHandle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

		[Ordinal(0)] [RED("("impulse")] 		public CFloat Impulse { get; set;}

		[Ordinal(0)] [RED("("impulseSpeedMax")] 		public CFloat ImpulseSpeedMax { get; set;}

		[Ordinal(0)] [RED("("sharpTurn")] 		public CBool SharpTurn { get; set;}

		[Ordinal(0)] [RED("("sharpTurnTime")] 		public CFloat SharpTurnTime { get; set;}

		[Ordinal(0)] [RED("("sharpTurnSpeed")] 		public CFloat SharpTurnSpeed { get; set;}

		[Ordinal(0)] [RED("("holdTurnSpeed")] 		public CFloat HoldTurnSpeed { get; set;}

		[Ordinal(0)] [RED("("chainTimeToDrift")] 		public CFloat ChainTimeToDrift { get; set;}

		[Ordinal(0)] [RED("("exiting")] 		public CBool Exiting { get; set;}

		[Ordinal(0)] [RED("("timeEndingMax")] 		public CFloat TimeEndingMax { get; set;}

		[Ordinal(0)] [RED("("timeEndingFlow")] 		public CBool TimeEndingFlow { get; set;}

		[Ordinal(0)] [RED("("timeEndingCur")] 		public CFloat TimeEndingCur { get; set;}

		[Ordinal(0)] [RED("("behDriftRestart")] 		public CName BehDriftRestart { get; set;}

		[Ordinal(0)] [RED("("behDriftEnd")] 		public CName BehDriftEnd { get; set;}

		[Ordinal(0)] [RED("("behDriftLeftSide")] 		public CName BehDriftLeftSide { get; set;}

		[Ordinal(0)] [RED("("sideIsLeft")] 		public CBool SideIsLeft { get; set;}

		public CExplorationStateSkatingDrift(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSkatingDrift(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}