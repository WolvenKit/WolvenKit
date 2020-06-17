using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskChangePriorityTillAnimEventDef : IBehTreeTaskDefinition
	{
		[RED("highPriority")] 		public CInt32 HighPriority { get; set;}

		[RED("defaultPriority")] 		public CInt32 DefaultPriority { get; set;}

		[RED("animEventName")] 		public CName AnimEventName { get; set;}

		public CBTTaskChangePriorityTillAnimEventDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskChangePriorityTillAnimEventDef(cr2w);

	}
}