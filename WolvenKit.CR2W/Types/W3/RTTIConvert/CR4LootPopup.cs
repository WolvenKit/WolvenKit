using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4LootPopup : CR4PopupBase
	{
		[RED("KEY_LOOT_ITEM_LIST")] 		public CString KEY_LOOT_ITEM_LIST { get; set;}

		[RED("_container")] 		public CHandle<W3Container> _container { get; set;}

		[RED("m_fxSetWindowTitle")] 		public CHandle<CScriptedFlashFunction> M_fxSetWindowTitle { get; set;}

		[RED("m_fxSetSelectionIndex")] 		public CHandle<CScriptedFlashFunction> M_fxSetSelectionIndex { get; set;}

		[RED("m_fxSetWindowScale")] 		public CHandle<CScriptedFlashFunction> M_fxSetWindowScale { get; set;}

		[RED("m_fxResizeBackground")] 		public CHandle<CScriptedFlashFunction> M_fxResizeBackground { get; set;}

		[RED("m_indexToSelect")] 		public CInt32 M_indexToSelect { get; set;}

		[RED("safeLock")] 		public CInt32 SafeLock { get; set;}

		[RED("inputContextSet")] 		public CBool InputContextSet { get; set;}

		public CR4LootPopup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4LootPopup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}