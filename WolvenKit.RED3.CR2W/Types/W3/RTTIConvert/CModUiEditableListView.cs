using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModUiEditableListView : CR4MenuBase
	{
		[Ordinal(1)] [RED("callback")] 		public CHandle<IModUiEditableListCallback> Callback { get; set;}

		[Ordinal(2)] [RED("log")] 		public CHandle<CModLogger> Log { get; set;}

		[Ordinal(3)] [RED("title")] 		public CString Title { get; set;}

		[Ordinal(4)] [RED("listData", 2,0)] 		public CArray<SModUiListItem> ListData { get; set;}

		[Ordinal(5)] [RED("txtField_setText")] 		public CHandle<CScriptedFlashFunction> TxtField_setText { get; set;}

		[Ordinal(6)] [RED("titleFieldId")] 		public SFlashArg TitleFieldId { get; set;}

		[Ordinal(7)] [RED("editFieldId")] 		public SFlashArg EditFieldId { get; set;}

		[Ordinal(8)] [RED("fieldLabel")] 		public CString FieldLabel { get; set;}

		[Ordinal(9)] [RED("inputString")] 		public CString InputString { get; set;}

		[Ordinal(10)] [RED("isEditActive")] 		public CBool IsEditActive { get; set;}

		[Ordinal(11)] [RED("isShiftHold")] 		public CBool IsShiftHold { get; set;}

		[Ordinal(12)] [RED("isCtrlHold")] 		public CBool IsCtrlHold { get; set;}

		[Ordinal(13)] [RED("cursorPos")] 		public CInt32 CursorPos { get; set;}

		[Ordinal(14)] [RED("statsFieldId")] 		public SFlashArg StatsFieldId { get; set;}

		[Ordinal(15)] [RED("statsLabel")] 		public CString StatsLabel { get; set;}

		[Ordinal(16)] [RED("statsListItems")] 		public CInt32 StatsListItems { get; set;}

		[Ordinal(17)] [RED("statsTotalItems")] 		public CInt32 StatsTotalItems { get; set;}

		[Ordinal(18)] [RED("HACK_useIgnoreNextSelectOnEditEndHack")] 		public CBool HACK_useIgnoreNextSelectOnEditEndHack { get; set;}

		[Ordinal(19)] [RED("HACK_ignoreNextSelect")] 		public CBool HACK_ignoreNextSelect { get; set;}

		public CModUiEditableListView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModUiEditableListView(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}