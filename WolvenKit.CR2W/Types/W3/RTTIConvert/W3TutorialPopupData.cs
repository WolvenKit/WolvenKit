using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialPopupData : CObject
	{
		[RED("posX")] 		public CFloat PosX { get; set;}

		[RED("posY")] 		public CFloat PosY { get; set;}

		[RED("messageTitle")] 		public CString MessageTitle { get; set;}

		[RED("messageText")] 		public CString MessageText { get; set;}

		[RED("imagePath")] 		public CString ImagePath { get; set;}

		[RED("fadeBackground")] 		public CBool FadeBackground { get; set;}

		[RED("autosize")] 		public CBool Autosize { get; set;}

		[RED("enableGlossoryLink")] 		public CBool EnableGlossoryLink { get; set;}

		[RED("enableAcceptButton")] 		public CBool EnableAcceptButton { get; set;}

		[RED("canBeShownInMenus")] 		public CBool CanBeShownInMenus { get; set;}

		[RED("blockInput")] 		public CBool BlockInput { get; set;}

		[RED("pauseGame")] 		public CBool PauseGame { get; set;}

		[RED("fullscreen")] 		public CBool Fullscreen { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("scriptTag")] 		public CName ScriptTag { get; set;}

		[RED("menuRef")] 		public CHandle<CR4TutorialPopup> MenuRef { get; set;}

		[RED("managerRef")] 		public CHandle<CR4TutorialSystem> ManagerRef { get; set;}

		[RED("closeRequested")] 		public CBool CloseRequested { get; set;}

		[RED("highlightedAreas", 2,0)] 		public CArray<TutorialHighlightedArea> HighlightedAreas { get; set;}

		public W3TutorialPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialPopupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}