using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4OverlayPopup : CR4PopupBase
	{
		[Ordinal(1)] [RED("m_InitDataObject")] 		public CHandle<W3NotificationData> M_InitDataObject { get; set;}

		[Ordinal(2)] [RED("m_fxShowNotification")] 		public CHandle<CScriptedFlashFunction> M_fxShowNotification { get; set;}

		[Ordinal(3)] [RED("m_fxHideNotification")] 		public CHandle<CScriptedFlashFunction> M_fxHideNotification { get; set;}

		[Ordinal(4)] [RED("m_fxClearNotificationsQueue")] 		public CHandle<CScriptedFlashFunction> M_fxClearNotificationsQueue { get; set;}

		[Ordinal(5)] [RED("m_fxShowLoadingIndicator")] 		public CHandle<CScriptedFlashFunction> M_fxShowLoadingIndicator { get; set;}

		[Ordinal(6)] [RED("m_fxHideLoadingIndicator")] 		public CHandle<CScriptedFlashFunction> M_fxHideLoadingIndicator { get; set;}

		[Ordinal(7)] [RED("m_fxShowSavingIndicator")] 		public CHandle<CScriptedFlashFunction> M_fxShowSavingIndicator { get; set;}

		[Ordinal(8)] [RED("m_fxHideSavingIndicator")] 		public CHandle<CScriptedFlashFunction> M_fxHideSavingIndicator { get; set;}

		[Ordinal(9)] [RED("m_fxAppendButton")] 		public CHandle<CScriptedFlashFunction> M_fxAppendButton { get; set;}

		[Ordinal(10)] [RED("m_fxRemoveButton")] 		public CHandle<CScriptedFlashFunction> M_fxRemoveButton { get; set;}

		[Ordinal(11)] [RED("m_fxRemoveContextButtons")] 		public CHandle<CScriptedFlashFunction> M_fxRemoveContextButtons { get; set;}

		[Ordinal(12)] [RED("m_fxUpdateButtons")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateButtons { get; set;}

		[Ordinal(13)] [RED("m_fxSetMouseCursorType")] 		public CHandle<CScriptedFlashFunction> M_fxSetMouseCursorType { get; set;}

		[Ordinal(14)] [RED("m_fxShowMouseCursor")] 		public CHandle<CScriptedFlashFunction> M_fxShowMouseCursor { get; set;}

		[Ordinal(15)] [RED("m_fxShowSafeRect")] 		public CHandle<CScriptedFlashFunction> M_fxShowSafeRect { get; set;}

		[Ordinal(16)] [RED("m_fxShowEP2Logo")] 		public CHandle<CScriptedFlashFunction> M_fxShowEP2Logo { get; set;}

		[Ordinal(17)] [RED("m_cursorRequested")] 		public CInt32 M_cursorRequested { get; set;}

		[Ordinal(18)] [RED("m_cursorHidden")] 		public CBool M_cursorHidden { get; set;}

		public CR4OverlayPopup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4OverlayPopup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}