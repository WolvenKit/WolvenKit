using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurSimulation : CVariable
	{
		[RED("simulate")] 		public CBool Simulate { get; set;}

		[RED("massScale")] 		public CFloat MassScale { get; set;}

		[RED("damping")] 		public CFloat Damping { get; set;}

		[RED("friction")] 		public CFloat Friction { get; set;}

		[RED("backStopRadius")] 		public CFloat BackStopRadius { get; set;}

		[RED("inertiaScale")] 		public CFloat InertiaScale { get; set;}

		[RED("inertiaLimit")] 		public CFloat InertiaLimit { get; set;}

		[RED("useCollision")] 		public CBool UseCollision { get; set;}

		[RED("windScaler")] 		public CFloat WindScaler { get; set;}

		[RED("windNoise")] 		public CFloat WindNoise { get; set;}

		[RED("gravityDir")] 		public Vector GravityDir { get; set;}

		public SFurSimulation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurSimulation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}