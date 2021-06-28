using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGuardAreaParameters : IAISpawnTreeSubParameters
	{
		[Ordinal(1)] [RED("guardArea")] 		public EntityHandle GuardArea { get; set;}

		[Ordinal(2)] [RED("guardPursuitArea")] 		public EntityHandle GuardPursuitArea { get; set;}

		[Ordinal(3)] [RED("guardPursuitRange")] 		public CFloat GuardPursuitRange { get; set;}

		public CGuardAreaParameters(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}