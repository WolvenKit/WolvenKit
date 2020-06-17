using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeSendScaredEventDefinition : IBehTreeNodeDefinition
	{
		[RED("becomeScared")] 		public CBool BecomeScared { get; set;}

		[RED("scaredTime")] 		public CBehTreeValFloat ScaredTime { get; set;}

		[RED("scaredTimeMax")] 		public CBehTreeValFloat ScaredTimeMax { get; set;}

		public CBehTreeNodeSendScaredEventDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeSendScaredEventDefinition(cr2w);

	}
}