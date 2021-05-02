using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJobForceOutAction : CJobActionBase
	{
		[Ordinal(1)] [RED("itemDropMode")] 		public CEnum<EJobForceOutDropMode> ItemDropMode { get; set;}

		[Ordinal(2)] [RED("speedMul")] 		public CFloat SpeedMul { get; set;}

		public CJobForceOutAction(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}