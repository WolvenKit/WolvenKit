using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFocusModeCombatCamera_CurveDamp_PC : CObject
	{
		[Ordinal(1)] [RED("pivotCurveName")] 		public CName PivotCurveName { get; set;}

		[Ordinal(2)] [RED("autoTimeUpdate")] 		public CBool AutoTimeUpdate { get; set;}

		[Ordinal(3)] [RED("pivotDamper")] 		public CHandle<CurveDamper3d> PivotDamper { get; set;}

		[Ordinal(4)] [RED("timeScale")] 		public CFloat TimeScale { get; set;}

		public CFocusModeCombatCamera_CurveDamp_PC(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}