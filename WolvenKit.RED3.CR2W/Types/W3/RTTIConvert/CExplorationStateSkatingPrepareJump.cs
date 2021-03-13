using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingPrepareJump : CExplorationInterceptorStateAbstract
	{
		[Ordinal(1)] [RED("skateGlobal")] 		public CHandle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

		[Ordinal(2)] [RED("behAnimEnd")] 		public CName BehAnimEnd { get; set;}

		[Ordinal(3)] [RED("timeMax")] 		public CFloat TimeMax { get; set;}

		[Ordinal(4)] [RED("flowImpulse")] 		public CFloat FlowImpulse { get; set;}

		public CExplorationStateSkatingPrepareJump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSkatingPrepareJump(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}