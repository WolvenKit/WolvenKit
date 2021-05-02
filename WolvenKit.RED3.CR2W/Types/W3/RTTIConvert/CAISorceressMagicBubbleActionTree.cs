using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAISorceressMagicBubbleActionTree : IAICustomActionTree
	{
		[Ordinal(1)] [RED("magicBubbleResourceName")] 		public CName MagicBubbleResourceName { get; set;}

		[Ordinal(2)] [RED("deactivate")] 		public CBool Deactivate { get; set;}

		[Ordinal(3)] [RED("playAnim")] 		public CBool PlayAnim { get; set;}

		public CAISorceressMagicBubbleActionTree(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAISorceressMagicBubbleActionTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}