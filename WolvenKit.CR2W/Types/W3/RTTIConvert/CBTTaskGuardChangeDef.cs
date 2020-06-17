using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskGuardChangeDef : IBehTreeTaskDefinition
	{
		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDectivate")] 		public CBool OnDectivate { get; set;}

		[RED("onMain")] 		public CBool OnMain { get; set;}

		[RED("frequency")] 		public CFloat Frequency { get; set;}

		[RED("raiseCheck")] 		public CBool RaiseCheck { get; set;}

		[RED("lowerCheck")] 		public CBool LowerCheck { get; set;}

		public CBTTaskGuardChangeDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskGuardChangeDef(cr2w);

	}
}