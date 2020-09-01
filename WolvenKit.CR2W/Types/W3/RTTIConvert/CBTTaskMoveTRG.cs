using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMoveTRG : IBehTreeTask
	{
		[Ordinal(0)] [RED("activationDistance")] 		public CFloat ActivationDistance { get; set;}

		[Ordinal(0)] [RED("fleeDistance")] 		public CFloat FleeDistance { get; set;}

		[Ordinal(0)] [RED("ignoreEntityWithTag")] 		public CName IgnoreEntityWithTag { get; set;}

		[Ordinal(0)] [RED("dangerNode")] 		public CHandle<CNode> DangerNode { get; set;}

		[Ordinal(0)] [RED("flee")] 		public CBool Flee { get; set;}

		public CBTTaskMoveTRG(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskMoveTRG(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}