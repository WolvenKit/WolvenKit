using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Elevator : CGameplayEntity
	{
		[RED("appearanceOnTop")] 		public CString AppearanceOnTop { get; set;}

		[RED("appearanceOnGround")] 		public CString AppearanceOnGround { get; set;}

		[RED("speed")] 		public CFloat Speed { get; set;}

		public W3Elevator(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3Elevator(cr2w);

	}
}