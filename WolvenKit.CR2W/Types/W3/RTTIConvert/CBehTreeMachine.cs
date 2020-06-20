using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeMachine : CObject
	{
		[RED("instance")] 		public CPtr<CBehTreeInstance> Instance { get; set;}

		[RED("aiRes")] 		public CHandle<CBehTree> AiRes { get; set;}

		[RED("aiParameters", 2,0)] 		public CArray<CHandle<IAIParameters>> AiParameters { get; set;}

		public CBehTreeMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeMachine(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}