using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TvInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] [RED("defaultUI")] public wCHandle<inkCanvasWidget> DefaultUI { get; set; }
		[Ordinal(17)] [RED("securedUI")] public wCHandle<inkCanvasWidget> SecuredUI { get; set; }
		[Ordinal(18)] [RED("channellTextWidget")] public wCHandle<inkTextWidget> ChannellTextWidget { get; set; }
		[Ordinal(19)] [RED("securedTextWidget")] public wCHandle<inkTextWidget> SecuredTextWidget { get; set; }
		[Ordinal(20)] [RED("mainDisplayWidget")] public wCHandle<inkVideoWidget> MainDisplayWidget { get; set; }
		[Ordinal(21)] [RED("actionsList")] public wCHandle<inkWidget> ActionsList { get; set; }
		[Ordinal(22)] [RED("activeChannelIDX")] public CInt32 ActiveChannelIDX { get; set; }
		[Ordinal(23)] [RED("activeSequence")] public CArray<SequenceVideo> ActiveSequence { get; set; }
		[Ordinal(24)] [RED("activeSequenceVideo")] public CInt32 ActiveSequenceVideo { get; set; }
		[Ordinal(25)] [RED("globalTVChannels")] public CArray<wCHandle<inkWidget>> GlobalTVChannels { get; set; }
		[Ordinal(26)] [RED("messegeWidget")] public wCHandle<inkTextWidget> MessegeWidget { get; set; }
		[Ordinal(27)] [RED("backgroundWidget")] public wCHandle<inkLeafWidget> BackgroundWidget { get; set; }
		[Ordinal(28)] [RED("previousGlobalTVChannelID")] public CInt32 PreviousGlobalTVChannelID { get; set; }
		[Ordinal(29)] [RED("globalTVchanellsCount")] public CInt32 GlobalTVchanellsCount { get; set; }
		[Ordinal(30)] [RED("globalTVchanellsSpawned")] public CInt32 GlobalTVchanellsSpawned { get; set; }
		[Ordinal(31)] [RED("globalTVslot")] public wCHandle<inkWidget> GlobalTVslot { get; set; }
		[Ordinal(32)] [RED("activeAudio")] public CName ActiveAudio { get; set; }
		[Ordinal(33)] [RED("activeMessage")] public wCHandle<gamedataScreenMessageData_Record> ActiveMessage { get; set; }
		[Ordinal(34)] [RED("onChangeChannelListener")] public CUInt32 OnChangeChannelListener { get; set; }
		[Ordinal(35)] [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }

		public TvInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
