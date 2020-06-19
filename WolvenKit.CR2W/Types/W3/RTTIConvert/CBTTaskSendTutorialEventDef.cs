using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSendTutorialEventDef : IBehTreeTaskDefinition
	{
		[RED("onActivation")] 		public CBool OnActivation { get; set;}

		[RED("onDeactivation")] 		public CBool OnDeactivation { get; set;}

		[RED("guardSwordWarning")] 		public CBool GuardSwordWarning { get; set;}

		[RED("guardGeneralWarning")] 		public CBool GuardGeneralWarning { get; set;}

		[RED("guardLootingWarning")] 		public CBool GuardLootingWarning { get; set;}

		public CBTTaskSendTutorialEventDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSendTutorialEventDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}