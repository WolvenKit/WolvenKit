using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSignProjectile : CVariable
	{
		[Ordinal(1)] [RED("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(2)] [RED("flyEffect")] 		public CName FlyEffect { get; set;}

		[Ordinal(3)] [RED("hitEffect")] 		public CName HitEffect { get; set;}

		[Ordinal(4)] [RED("targetHitEffect")] 		public CName TargetHitEffect { get; set;}

		[Ordinal(5)] [RED("lastingTime")] 		public CFloat LastingTime { get; set;}

		public SSignProjectile(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}