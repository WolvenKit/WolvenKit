using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TrapProjectileArea_CreateEntityHelper : CCreateEntityHelper
	{
		[RED("owner")] 		public CHandle<W3TrapProjectileArea> Owner { get; set;}

		[RED("velocity")] 		public CFloat Velocity { get; set;}

		[RED("targetPos")] 		public Vector TargetPos { get; set;}

		public W3TrapProjectileArea_CreateEntityHelper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TrapProjectileArea_CreateEntityHelper(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}