using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModSbListViewWorkMode : CModStoryBoardWorkMode
	{
		[Ordinal(1)] [RED("view")] 		public CHandle<CModSbWorkModeUiListCallback> View { get; set;}

		[Ordinal(2)] [RED("confirmPopup")] 		public CHandle<CModUiActionConfirmation> ConfirmPopup { get; set;}

		[Ordinal(3)] [RED("popupCallback")] 		public CHandle<CModSbWorkModePopupCallback> PopupCallback { get; set;}

		public CModSbListViewWorkMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModSbListViewWorkMode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}