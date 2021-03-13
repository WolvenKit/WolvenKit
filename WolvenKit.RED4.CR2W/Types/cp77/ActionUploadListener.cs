using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionUploadListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] [RED("action")] public CHandle<ScriptableDeviceAction> Action { get; set; }
		[Ordinal(1)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }

		public ActionUploadListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
