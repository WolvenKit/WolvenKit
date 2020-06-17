using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphBlendMultipleCondNode_Multi : IBehaviorGraphBlendMultipleCondNode_Condition
	{
		[RED("conditions", 2,0)] 		public CArray<CPtr<IBehaviorGraphBlendMultipleCondNode_Condition>> Conditions { get; set;}

		[RED("logicAndOr")] 		public CBool LogicAndOr { get; set;}

		public CBehaviorGraphBlendMultipleCondNode_Multi(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphBlendMultipleCondNode_Multi(cr2w);

	}
}