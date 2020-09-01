using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingHitLateral : CExplorationStateAbstract
	{
		[Ordinal(0)] [RED("("skateGlobal")] 		public CHandle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

		[Ordinal(0)] [RED("("behAnimEnd")] 		public CName BehAnimEnd { get; set;}

		[Ordinal(0)] [RED("("timeMax")] 		public CFloat TimeMax { get; set;}

		[Ordinal(0)] [RED("("speedMinToEnter")] 		public CFloat SpeedMinToEnter { get; set;}

		[Ordinal(0)] [RED("("speedReductionPerc")] 		public CFloat SpeedReductionPerc { get; set;}

		[Ordinal(0)] [RED("("extraAngle")] 		public CFloat ExtraAngle { get; set;}

		public CExplorationStateSkatingHitLateral(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSkatingHitLateral(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}