using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CiriPhantom : CGameplayEntity
	{
		[Ordinal(1)] [RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[Ordinal(2)] [RED("target")] 		public CHandle<CActor> Target { get; set;}

		[Ordinal(3)] [RED("rotationDamper")] 		public CHandle<EulerAnglesSpringDamper> RotationDamper { get; set;}

		public W3CiriPhantom(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}