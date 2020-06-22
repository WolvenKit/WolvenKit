using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFocusModeCombatCamera_CurveDamp_MC : CObject
	{
		[RED("distanceCurveName")] 		public CName DistanceCurveName { get; set;}

		[RED("yawCurveName")] 		public CName YawCurveName { get; set;}

		[RED("pitchCurveName")] 		public CName PitchCurveName { get; set;}

		[RED("fovCurveName")] 		public CName FovCurveName { get; set;}

		[RED("desiredPitch")] 		public CFloat DesiredPitch { get; set;}

		[RED("autoTimeUpdate")] 		public CBool AutoTimeUpdate { get; set;}

		[RED("distanceDamper")] 		public CHandle<CurveDamper> DistanceDamper { get; set;}

		[RED("yawDamper")] 		public CHandle<AngleCurveDamper> YawDamper { get; set;}

		[RED("pitchDamper")] 		public CHandle<AngleCurveDamper> PitchDamper { get; set;}

		[RED("fovDamper")] 		public CHandle<CurveDamper> FovDamper { get; set;}

		[RED("distanceStart")] 		public CFloat DistanceStart { get; set;}

		[RED("pitchStart")] 		public CFloat PitchStart { get; set;}

		[RED("yawStart")] 		public CFloat YawStart { get; set;}

		[RED("position")] 		public Vector Position { get; set;}

		[RED("rotation")] 		public EulerAngles Rotation { get; set;}

		[RED("timeScale")] 		public CFloat TimeScale { get; set;}

		public CFocusModeCombatCamera_CurveDamp_MC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFocusModeCombatCamera_CurveDamp_MC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}