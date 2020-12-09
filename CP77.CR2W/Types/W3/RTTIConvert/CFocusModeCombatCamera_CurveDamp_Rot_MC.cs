using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFocusModeCombatCamera_CurveDamp_Rot_MC : CFocusModeCombatCamera_CurveDamp_MC
	{
		[Ordinal(1)] [RED("rollCurveName")] 		public CName RollCurveName { get; set;}

		[Ordinal(2)] [RED("posCurveName")] 		public CName PosCurveName { get; set;}

		[Ordinal(3)] [RED("rollDamper")] 		public CHandle<AngleCurveDamper> RollDamper { get; set;}

		[Ordinal(4)] [RED("posDamper")] 		public CHandle<CurveDamper3d> PosDamper { get; set;}

		public CFocusModeCombatCamera_CurveDamp_Rot_MC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFocusModeCombatCamera_CurveDamp_Rot_MC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}