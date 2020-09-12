using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurSimulation : CVariable
	{
		[Ordinal(1)] [RED("simulate")] 		public CBool Simulate { get; set;}

		[Ordinal(2)] [RED("massScale")] 		public CFloat MassScale { get; set;}

		[Ordinal(3)] [RED("damping")] 		public CFloat Damping { get; set;}

		[Ordinal(4)] [RED("friction")] 		public CFloat Friction { get; set;}

		[Ordinal(5)] [RED("backStopRadius")] 		public CFloat BackStopRadius { get; set;}

		[Ordinal(6)] [RED("inertiaScale")] 		public CFloat InertiaScale { get; set;}

		[Ordinal(7)] [RED("inertiaLimit")] 		public CFloat InertiaLimit { get; set;}

		[Ordinal(8)] [RED("useCollision")] 		public CBool UseCollision { get; set;}

		[Ordinal(9)] [RED("windScaler")] 		public CFloat WindScaler { get; set;}

		[Ordinal(10)] [RED("windNoise")] 		public CFloat WindNoise { get; set;}

		[Ordinal(11)] [RED("gravityDir")] 		public Vector GravityDir { get; set;}

		public SFurSimulation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurSimulation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}