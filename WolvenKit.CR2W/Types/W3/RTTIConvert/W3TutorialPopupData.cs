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
		[Ordinal(0)] [RED("("posX")] 		public CFloat PosX { get; set;}

		[Ordinal(0)] [RED("("posY")] 		public CFloat PosY { get; set;}

		[Ordinal(0)] [RED("("messageTitle")] 		public CString MessageTitle { get; set;}

		[Ordinal(0)] [RED("("messageText")] 		public CString MessageText { get; set;}

		[Ordinal(0)] [RED("("imagePath")] 		public CString ImagePath { get; set;}

		[Ordinal(0)] [RED("("fadeBackground")] 		public CBool FadeBackground { get; set;}

		[Ordinal(0)] [RED("("autosize")] 		public CBool Autosize { get; set;}

		[Ordinal(0)] [RED("("enableGlossoryLink")] 		public CBool EnableGlossoryLink { get; set;}

		[Ordinal(0)] [RED("("enableAcceptButton")] 		public CBool EnableAcceptButton { get; set;}

		[Ordinal(0)] [RED("("canBeShownInMenus")] 		public CBool CanBeShownInMenus { get; set;}

		[Ordinal(0)] [RED("("blockInput")] 		public CBool BlockInput { get; set;}

		[Ordinal(0)] [RED("("pauseGame")] 		public CBool PauseGame { get; set;}

		[Ordinal(0)] [RED("("fullscreen")] 		public CBool Fullscreen { get; set;}

		[Ordinal(0)] [RED("("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(0)] [RED("("scriptTag")] 		public CName ScriptTag { get; set;}

		[Ordinal(0)] [RED("("menuRef")] 		public CHandle<CR4TutorialPopup> MenuRef { get; set;}

		[Ordinal(0)] [RED("("managerRef")] 		public CHandle<CR4TutorialSystem> ManagerRef { get; set;}

		[Ordinal(0)] [RED("("closeRequested")] 		public CBool CloseRequested { get; set;}

		[Ordinal(0)] [RED("("highlightedAreas", 2,0)] 		public CArray<TutorialHighlightedArea> HighlightedAreas { get; set;}

		public W3TutorialPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialPopupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}