using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BraindanceSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("debugFFSceneThrehsold")] public CInt32 DebugFFSceneThrehsold { get; set; }
		[Ordinal(1)]  [RED("inputMask")] public SBraindanceInputMask InputMask { get; set; }
		[Ordinal(2)]  [RED("isInBraindance")] public CBool IsInBraindance { get; set; }
		[Ordinal(3)]  [RED("pauseBraindanceRequest")] public CBool PauseBraindanceRequest { get; set; }
		[Ordinal(4)]  [RED("requestCameraToggle")] public CBool RequestCameraToggle { get; set; }
		[Ordinal(5)]  [RED("requestEditorState")] public CBool RequestEditorState { get; set; }

		public BraindanceSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
