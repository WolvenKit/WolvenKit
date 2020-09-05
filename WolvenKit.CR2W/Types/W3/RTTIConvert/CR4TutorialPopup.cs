using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4TutorialPopup : CR4PopupBase
	{
		[Ordinal(1)] [RED("m_DataObject")] 		public CHandle<W3TutorialPopupData> M_DataObject { get; set;}

		[Ordinal(2)] [RED("timeRemains")] 		public CFloat TimeRemains { get; set;}

		[Ordinal(3)] [RED("removeOnTimer")] 		public CBool RemoveOnTimer { get; set;}

		[Ordinal(4)] [RED("enableGlossaryLink")] 		public CBool EnableGlossaryLink { get; set;}

		[Ordinal(5)] [RED("hideCounter")] 		public CInt32 HideCounter { get; set;}

		[Ordinal(6)] [RED("forcedhideCounter")] 		public CInt32 ForcedhideCounter { get; set;}

		[Ordinal(7)] [RED("isVisible")] 		public CBool IsVisible { get; set;}

		[Ordinal(8)] [RED("m_fxPlayFeedbackAnim")] 		public CHandle<CScriptedFlashFunction> M_fxPlayFeedbackAnim { get; set;}

		[Ordinal(9)] [RED("m_fxResetInput")] 		public CHandle<CScriptedFlashFunction> M_fxResetInput { get; set;}

		[Ordinal(10)] [RED("m_contextStored")] 		public CBool M_contextStored { get; set;}

		public CR4TutorialPopup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4TutorialPopup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}