using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4MessagePopup : CR4PopupBase
	{
		[Ordinal(1)] [RED("m_messagesQueue", 2,0)] 		public CArray<CHandle<W3MessagePopupData>> M_messagesQueue { get; set;}

		[Ordinal(2)] [RED("m_isMessageShown")] 		public CBool M_isMessageShown { get; set;}

		[Ordinal(3)] [RED("m_fxHideMessage")] 		public CHandle<CScriptedFlashFunction> M_fxHideMessage { get; set;}

		[Ordinal(4)] [RED("m_fxPrepareMessageShow")] 		public CHandle<CScriptedFlashFunction> M_fxPrepareMessageShow { get; set;}

		[Ordinal(5)] [RED("m_fxDisplayProgressBar")] 		public CHandle<CScriptedFlashFunction> M_fxDisplayProgressBar { get; set;}

		public CR4MessagePopup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4MessagePopup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}