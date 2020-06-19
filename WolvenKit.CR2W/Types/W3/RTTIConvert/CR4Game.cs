using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4Game : CCommonGame
	{
		[RED("horseCamera")] 		public CHandle<CCustomCamera> HorseCamera { get; set;}

		[RED("telemetryScriptProxy")] 		public CPtr<CR4TelemetryScriptProxy> TelemetryScriptProxy { get; set;}

		[RED("secondScreenScriptProxy")] 		public CPtr<CR4SecondScreenManagerScriptProxy> SecondScreenScriptProxy { get; set;}

		[RED("kinectSpeechRecognizerListenerScriptProxy")] 		public CPtr<CR4KinectSpeechRecognizerListenerScriptProxy> KinectSpeechRecognizerListenerScriptProxy { get; set;}

		[RED("ticketsDefaultConfiguration")] 		public CPtr<CTicketsDefaultConfiguration> TicketsDefaultConfiguration { get; set;}

		[RED("globalEventsScriptsDispatcher")] 		public CPtr<CR4GlobalEventsScriptsDispatcher> GlobalEventsScriptsDispatcher { get; set;}

		[RED("worldDLCExtender")] 		public CPtr<CR4WorldDLCExtender> WorldDLCExtender { get; set;}

		[RED("globalTicketSource")] 		public CHandle<CGlabalTicketSourceProvider> GlobalTicketSource { get; set;}

		[RED("carryableItemsRegistry")] 		public CHandle<CCarryableItemsRegistry> CarryableItemsRegistry { get; set;}

		[RED("params")] 		public CHandle<W3GameParams> Params { get; set;}

		public CR4Game(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4Game(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}