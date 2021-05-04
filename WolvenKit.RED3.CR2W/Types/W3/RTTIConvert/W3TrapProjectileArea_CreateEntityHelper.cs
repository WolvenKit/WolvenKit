using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TrapProjectileArea_CreateEntityHelper : CCreateEntityHelper
	{
		[Ordinal(1)] [RED("owner")] 		public CHandle<W3TrapProjectileArea> Owner { get; set;}

		[Ordinal(2)] [RED("velocity")] 		public CFloat Velocity { get; set;}

		[Ordinal(3)] [RED("targetPos")] 		public Vector TargetPos { get; set;}

		public W3TrapProjectileArea_CreateEntityHelper(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}