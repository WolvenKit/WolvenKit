using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIReaction : CObject
	{
		[RED("fieldName")] 		public CName FieldName { get; set;}

		[RED("cooldownTime")] 		public CFloat CooldownTime { get; set;}

		[RED("visibilityTest")] 		public EVisibilityTest VisibilityTest { get; set;}

		[RED("range")] 		public SAIReactionRange Range { get; set;}

		[RED("factTest")] 		public SAIReactionFactTest FactTest { get; set;}

		[RED("condition")] 		public CPtr<IReactionCondition> Condition { get; set;}

		[RED("action")] 		public CPtr<IReactionAction> Action { get; set;}

		public CAIReaction(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIReaction(cr2w);

	}
}