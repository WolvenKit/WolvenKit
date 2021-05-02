using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetUnstoppableDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(2)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(3)] [RED("onSuccess")] 		public CBool OnSuccess { get; set;}

		[Ordinal(4)] [RED("overrideForThisTask")] 		public CBool OverrideForThisTask { get; set;}

		[Ordinal(5)] [RED("makeUnpushable")] 		public CBool MakeUnpushable { get; set;}

		[Ordinal(6)] [RED("enable")] 		public CBool Enable { get; set;}

		public CBTTaskSetUnstoppableDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}