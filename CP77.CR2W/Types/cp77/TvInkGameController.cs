using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TvInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("actionsList")] public wCHandle<inkWidget> ActionsList { get; set; }
		[Ordinal(1)]  [RED("activeAudio")] public CName ActiveAudio { get; set; }
		[Ordinal(2)]  [RED("activeChannelIDX")] public CInt32 ActiveChannelIDX { get; set; }
		[Ordinal(3)]  [RED("activeMessage")] public wCHandle<gamedataScreenMessageData_Record> ActiveMessage { get; set; }
		[Ordinal(4)]  [RED("activeSequence")] public CArray<SequenceVideo> ActiveSequence { get; set; }
		[Ordinal(5)]  [RED("activeSequenceVideo")] public CInt32 ActiveSequenceVideo { get; set; }
		[Ordinal(6)]  [RED("backgroundWidget")] public wCHandle<inkLeafWidget> BackgroundWidget { get; set; }
		[Ordinal(7)]  [RED("channellTextWidget")] public wCHandle<inkTextWidget> ChannellTextWidget { get; set; }
		[Ordinal(8)]  [RED("defaultUI")] public wCHandle<inkCanvasWidget> DefaultUI { get; set; }
		[Ordinal(9)]  [RED("globalTVChannels")] public CArray<wCHandle<inkWidget>> GlobalTVChannels { get; set; }
		[Ordinal(10)]  [RED("globalTVchanellsCount")] public CInt32 GlobalTVchanellsCount { get; set; }
		[Ordinal(11)]  [RED("globalTVchanellsSpawned")] public CInt32 GlobalTVchanellsSpawned { get; set; }
		[Ordinal(12)]  [RED("globalTVslot")] public wCHandle<inkWidget> GlobalTVslot { get; set; }
		[Ordinal(13)]  [RED("mainDisplayWidget")] public wCHandle<inkVideoWidget> MainDisplayWidget { get; set; }
		[Ordinal(14)]  [RED("messegeWidget")] public wCHandle<inkTextWidget> MessegeWidget { get; set; }
		[Ordinal(15)]  [RED("onChangeChannelListener")] public CUInt32 OnChangeChannelListener { get; set; }
		[Ordinal(16)]  [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }
		[Ordinal(17)]  [RED("previousGlobalTVChannelID")] public CInt32 PreviousGlobalTVChannelID { get; set; }
		[Ordinal(18)]  [RED("securedTextWidget")] public wCHandle<inkTextWidget> SecuredTextWidget { get; set; }
		[Ordinal(19)]  [RED("securedUI")] public wCHandle<inkCanvasWidget> SecuredUI { get; set; }

		public TvInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
