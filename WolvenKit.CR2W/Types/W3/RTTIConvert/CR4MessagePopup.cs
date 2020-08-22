using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4MessagePopup : CR4PopupBase
	{
		[RED("m_messagesQueue", 2,0)] 		public CArray<CHandle<W3MessagePopupData>> M_messagesQueue { get; set;}

		[RED("m_isMessageShown")] 		public CBool M_isMessageShown { get; set;}

		[RED("m_fxHideMessage")] 		public CHandle<CScriptedFlashFunction> M_fxHideMessage { get; set;}

		[RED("m_fxPrepareMessageShow")] 		public CHandle<CScriptedFlashFunction> M_fxPrepareMessageShow { get; set;}

		[RED("m_fxDisplayProgressBar")] 		public CHandle<CScriptedFlashFunction> M_fxDisplayProgressBar { get; set;}

		public CR4MessagePopup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4MessagePopup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}