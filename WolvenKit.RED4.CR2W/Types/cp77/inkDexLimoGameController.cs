using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDexLimoGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("activeVehicleBlackboard")] public CHandle<gameIBlackboard> ActiveVehicleBlackboard { get; set; }
		[Ordinal(3)] [RED("playerVehStateId")] public CUInt32 PlayerVehStateId { get; set; }
		[Ordinal(4)] [RED("screenVideoWidget")] public wCHandle<inkVideoWidget> ScreenVideoWidget { get; set; }
		[Ordinal(5)] [RED("screenVideoWidgetPath")] public CName ScreenVideoWidgetPath { get; set; }
		[Ordinal(6)] [RED("videoPath")] public redResourceReferenceScriptToken VideoPath { get; set; }

		public inkDexLimoGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
