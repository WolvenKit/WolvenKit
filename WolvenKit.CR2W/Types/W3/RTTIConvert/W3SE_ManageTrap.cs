using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SE_ManageTrap : W3SwitchEvent
	{
		[RED("trapHandle", 2,0)] 		public CArray<EntityHandle> TrapHandle { get; set;}

		[RED("trapTag")] 		public CName TrapTag { get; set;}

		[RED("operations", 2,0)] 		public CArray<CEnum<ETrapOperation>> Operations { get; set;}

		public W3SE_ManageTrap(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3SE_ManageTrap(cr2w);

	}
}