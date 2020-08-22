using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CiriPhantom : CGameplayEntity
	{
		[RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[RED("target")] 		public CHandle<CActor> Target { get; set;}

		[RED("rotationDamper")] 		public CHandle<EulerAnglesSpringDamper> RotationDamper { get; set;}

		public W3CiriPhantom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3CiriPhantom(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}