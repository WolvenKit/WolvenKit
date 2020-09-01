using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskChangePriorityTillAnimEventDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("highPriority")] 		public CInt32 HighPriority { get; set;}

		[Ordinal(0)] [RED("defaultPriority")] 		public CInt32 DefaultPriority { get; set;}

		[Ordinal(0)] [RED("animEventName")] 		public CName AnimEventName { get; set;}

		public CBTTaskChangePriorityTillAnimEventDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskChangePriorityTillAnimEventDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}