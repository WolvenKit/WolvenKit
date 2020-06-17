using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestInteractionCondition : IQuestCondition
	{
		[RED("interactionName")] 		public CString InteractionName { get; set;}

		[RED("ownerTags")] 		public TagList OwnerTags { get; set;}

		public CQuestInteractionCondition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CQuestInteractionCondition(cr2w);

	}
}