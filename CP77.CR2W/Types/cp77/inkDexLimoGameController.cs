using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkDexLimoGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("activeVehicleBlackboard")] public CHandle<gameIBlackboard> ActiveVehicleBlackboard { get; set; }
		[Ordinal(1)]  [RED("playerVehStateId")] public CUInt32 PlayerVehStateId { get; set; }
		[Ordinal(2)]  [RED("screenVideoWidget")] public wCHandle<inkVideoWidget> ScreenVideoWidget { get; set; }
		[Ordinal(3)]  [RED("screenVideoWidgetPath")] public CName ScreenVideoWidgetPath { get; set; }
		[Ordinal(4)]  [RED("videoPath")] public redResourceReferenceScriptToken VideoPath { get; set; }

		public inkDexLimoGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
