using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardUi : CMod
	{
		[Ordinal(1)] [RED("confirmPopup")] 		public CHandle<CModUiActionConfirmation> ConfirmPopup { get; set;}

		[Ordinal(2)] [RED("viewCallback")] 		public CHandle<CModSbUiPopupCallback> ViewCallback { get; set;}

		[Ordinal(3)] [RED("storyboard")] 		public CHandle<CModStoryBoard> Storyboard { get; set;}

		[Ordinal(4)] [RED("currentMode")] 		public CHandle<CModStoryBoardWorkMode> CurrentMode { get; set;}

		[Ordinal(5)] [RED("modeCallback")] 		public CHandle<CModSbUiParentCallback> ModeCallback { get; set;}

		[Ordinal(6)] [RED("hudModules", 2,0)] 		public CArray<CName> HudModules { get; set;}

		[Ordinal(7)] [RED("hudModulesEnabled", 2,0)] 		public CArray<CBool> HudModulesEnabled { get; set;}

		[Ordinal(8)] [RED("hoursPerMinute")] 		public CFloat HoursPerMinute { get; set;}

		public CModStoryBoardUi(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardUi(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}