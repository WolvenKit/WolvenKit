using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskEnableLookAt : IBehTreeTask
	{
		[Ordinal(1)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(2)] [RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[Ordinal(3)] [RED("useReactionTarget")] 		public CBool UseReactionTarget { get; set;}

		[Ordinal(4)] [RED("useActionTarget")] 		public CBool UseActionTarget { get; set;}

		[Ordinal(5)] [RED("useAsDecorator")] 		public CBool UseAsDecorator { get; set;}

		public CBTTaskEnableLookAt(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}