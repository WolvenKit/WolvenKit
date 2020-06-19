using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBoatComponent : CVehicleComponent
	{
		[RED("sailDir")] 		public CFloat SailDir { get; set;}

		[RED("mountAnimationFinished")] 		public CBool MountAnimationFinished { get; set;}

		[RED("collisionNames", 2,0)] 		public CArray<CName> CollisionNames { get; set;}

		public CBoatComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBoatComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}