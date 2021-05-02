using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskChangePriorityTillAnimEvent : IBehTreeTask
	{
		[Ordinal(1)] [RED("highPriority")] 		public CInt32 HighPriority { get; set;}

		[Ordinal(2)] [RED("defaultPriority")] 		public CInt32 DefaultPriority { get; set;}

		[Ordinal(3)] [RED("animEventName")] 		public CName AnimEventName { get; set;}

		[Ordinal(4)] [RED("allowBlend")] 		public CBool AllowBlend { get; set;}

		public CBTTaskChangePriorityTillAnimEvent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskChangePriorityTillAnimEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}