using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4TutorialPopup : CR4PopupBase
	{
		[RED("m_DataObject")] 		public CHandle<W3TutorialPopupData> M_DataObject { get; set;}

		[RED("timeRemains")] 		public CFloat TimeRemains { get; set;}

		[RED("removeOnTimer")] 		public CBool RemoveOnTimer { get; set;}

		[RED("enableGlossaryLink")] 		public CBool EnableGlossaryLink { get; set;}

		[RED("hideCounter")] 		public CInt32 HideCounter { get; set;}

		[RED("forcedhideCounter")] 		public CInt32 ForcedhideCounter { get; set;}

		[RED("isVisible")] 		public CBool IsVisible { get; set;}

		[RED("m_fxPlayFeedbackAnim")] 		public CHandle<CScriptedFlashFunction> M_fxPlayFeedbackAnim { get; set;}

		[RED("m_fxResetInput")] 		public CHandle<CScriptedFlashFunction> M_fxResetInput { get; set;}

		[RED("m_contextStored")] 		public CBool M_contextStored { get; set;}

		public CR4TutorialPopup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4TutorialPopup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}