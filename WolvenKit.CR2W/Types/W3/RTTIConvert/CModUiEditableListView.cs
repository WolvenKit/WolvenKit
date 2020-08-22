using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModUiEditableListView : CR4MenuBase
	{
		[RED("callback")] 		public CHandle<IModUiEditableListCallback> Callback { get; set;}

		[RED("log")] 		public CHandle<CModLogger> Log { get; set;}

		[RED("title")] 		public CString Title { get; set;}

		[RED("listData", 2,0)] 		public CArray<SModUiListItem> ListData { get; set;}

		[RED("txtField_setText")] 		public CHandle<CScriptedFlashFunction> TxtField_setText { get; set;}

		[RED("titleFieldId")] 		public SFlashArg TitleFieldId { get; set;}

		[RED("editFieldId")] 		public SFlashArg EditFieldId { get; set;}

		[RED("fieldLabel")] 		public CString FieldLabel { get; set;}

		[RED("inputString")] 		public CString InputString { get; set;}

		[RED("isEditActive")] 		public CBool IsEditActive { get; set;}

		[RED("isShiftHold")] 		public CBool IsShiftHold { get; set;}

		[RED("isCtrlHold")] 		public CBool IsCtrlHold { get; set;}

		[RED("cursorPos")] 		public CInt32 CursorPos { get; set;}

		[RED("statsFieldId")] 		public SFlashArg StatsFieldId { get; set;}

		[RED("statsLabel")] 		public CString StatsLabel { get; set;}

		[RED("statsListItems")] 		public CInt32 StatsListItems { get; set;}

		[RED("statsTotalItems")] 		public CInt32 StatsTotalItems { get; set;}

		[RED("HACK_useIgnoreNextSelectOnEditEndHack")] 		public CBool HACK_useIgnoreNextSelectOnEditEndHack { get; set;}

		[RED("HACK_ignoreNextSelect")] 		public CBool HACK_ignoreNextSelect { get; set;}

		public CModUiEditableListView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModUiEditableListView(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}