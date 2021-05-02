using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcActiveIdle : CAIIdleTree
	{
		[Ordinal(1)] [RED("params")] 		public CHandle<CAINpcActiveIdleParams> Params { get; set;}

		[Ordinal(2)] [RED("delayWorkOnFailure")] 		public CFloat DelayWorkOnFailure { get; set;}

		[Ordinal(3)] [RED("delayWorkOnSuccess")] 		public CFloat DelayWorkOnSuccess { get; set;}

		[Ordinal(4)] [RED("delayWorkOnInterruption")] 		public CFloat DelayWorkOnInterruption { get; set;}

		public CAINpcActiveIdle(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}