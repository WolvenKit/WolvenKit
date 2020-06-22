using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskEnableLookAt : IBehTreeTask
	{
		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[RED("useReactionTarget")] 		public CBool UseReactionTarget { get; set;}

		[RED("useActionTarget")] 		public CBool UseActionTarget { get; set;}

		[RED("useAsDecorator")] 		public CBool UseAsDecorator { get; set;}

		public CBTTaskEnableLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskEnableLookAt(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}