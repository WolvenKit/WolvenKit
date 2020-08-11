using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateMutationsCharPanelUnlockedSkillSlot : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("ADDITIONAL_SLOT")] 		public CName ADDITIONAL_SLOT { get; set;}

		[RED("COLOR")] 		public CName COLOR { get; set;}

		[RED("YELLOW")] 		public CName YELLOW { get; set;}

		[RED("isClosing")] 		public CBool IsClosing { get; set;}

		[RED("selectedMutation")] 		public CEnum<EPlayerMutationType> SelectedMutation { get; set;}

		public W3TutorialManagerUIHandlerStateMutationsCharPanelUnlockedSkillSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateMutationsCharPanelUnlockedSkillSlot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}