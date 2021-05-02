using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeDecoratorSemaphoreDefinition : IBehTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] [RED("semaphoreName")] 		public CName SemaphoreName { get; set;}

		[Ordinal(2)] [RED("raise")] 		public CBool Raise { get; set;}

		public CBehTreeNodeDecoratorSemaphoreDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeDecoratorSemaphoreDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}