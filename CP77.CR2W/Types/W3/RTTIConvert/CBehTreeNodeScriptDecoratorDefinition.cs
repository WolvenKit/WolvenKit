using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeScriptDecoratorDefinition : IBehTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] [RED("forwardAvailability")] 		public CBool ForwardAvailability { get; set;}

		[Ordinal(2)] [RED("forwardTestIfNotAvailable")] 		public CBool ForwardTestIfNotAvailable { get; set;}

		[Ordinal(3)] [RED("invertAvailability")] 		public CBool InvertAvailability { get; set;}

		[Ordinal(4)] [RED("skipIfActive")] 		public CBool SkipIfActive { get; set;}

		[Ordinal(5)] [RED("runMainOnActivation")] 		public CBool RunMainOnActivation { get; set;}

		[Ordinal(6)] [RED("taskOrigin")] 		public CHandle<IBehTreeTaskDefinition> TaskOrigin { get; set;}

		public CBehTreeNodeScriptDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeScriptDecoratorDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}