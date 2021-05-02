using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFocusModeCombatCamera_CurveDamp_MC : CObject
	{
		[Ordinal(1)] [RED("distanceCurveName")] 		public CName DistanceCurveName { get; set;}

		[Ordinal(2)] [RED("yawCurveName")] 		public CName YawCurveName { get; set;}

		[Ordinal(3)] [RED("pitchCurveName")] 		public CName PitchCurveName { get; set;}

		[Ordinal(4)] [RED("fovCurveName")] 		public CName FovCurveName { get; set;}

		[Ordinal(5)] [RED("desiredPitch")] 		public CFloat DesiredPitch { get; set;}

		[Ordinal(6)] [RED("autoTimeUpdate")] 		public CBool AutoTimeUpdate { get; set;}

		[Ordinal(7)] [RED("distanceDamper")] 		public CHandle<CurveDamper> DistanceDamper { get; set;}

		[Ordinal(8)] [RED("yawDamper")] 		public CHandle<AngleCurveDamper> YawDamper { get; set;}

		[Ordinal(9)] [RED("pitchDamper")] 		public CHandle<AngleCurveDamper> PitchDamper { get; set;}

		[Ordinal(10)] [RED("fovDamper")] 		public CHandle<CurveDamper> FovDamper { get; set;}

		[Ordinal(11)] [RED("distanceStart")] 		public CFloat DistanceStart { get; set;}

		[Ordinal(12)] [RED("pitchStart")] 		public CFloat PitchStart { get; set;}

		[Ordinal(13)] [RED("yawStart")] 		public CFloat YawStart { get; set;}

		[Ordinal(14)] [RED("position")] 		public Vector Position { get; set;}

		[Ordinal(15)] [RED("rotation")] 		public EulerAngles Rotation { get; set;}

		[Ordinal(16)] [RED("timeScale")] 		public CFloat TimeScale { get; set;}

		public CFocusModeCombatCamera_CurveDamp_MC(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFocusModeCombatCamera_CurveDamp_MC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}