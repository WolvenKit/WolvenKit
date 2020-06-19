using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSoundEmitterComponent : CComponent
	{
		[RED("loopStart")] 		public StringAnsi LoopStart { get; set;}

		[RED("loopStop")] 		public StringAnsi LoopStop { get; set;}

		[RED("intensityParameter")] 		public StringAnsi IntensityParameter { get; set;}

		[RED("eventsOnAttach", 2,0)] 		public CArray<StringAnsi> EventsOnAttach { get; set;}

		[RED("eventsOnDetach", 2,0)] 		public CArray<StringAnsi> EventsOnDetach { get; set;}

		[RED("banksDependency", 2,0)] 		public CArray<CName> BanksDependency { get; set;}

		[RED("switchesOnAttach", 2,0)] 		public CArray<SSoundSwitch> SwitchesOnAttach { get; set;}

		[RED("rtpcsOnAttach", 2,0)] 		public CArray<SSoundProperty> RtpcsOnAttach { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("occlusionEnabled")] 		public CBool OcclusionEnabled { get; set;}

		[RED("isInGameMusic")] 		public CBool IsInGameMusic { get; set;}

		[RED("listenerOverride")] 		public CString ListenerOverride { get; set;}

		[RED("updateAzimuth")] 		public CBool UpdateAzimuth { get; set;}

		public CSoundEmitterComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSoundEmitterComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}