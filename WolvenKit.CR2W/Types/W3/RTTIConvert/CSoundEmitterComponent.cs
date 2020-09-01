using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSoundEmitterComponent : CComponent
	{
		[Ordinal(0)] [RED("loopStart")] 		public StringAnsi LoopStart { get; set;}

		[Ordinal(0)] [RED("loopStop")] 		public StringAnsi LoopStop { get; set;}

		[Ordinal(0)] [RED("intensityParameter")] 		public StringAnsi IntensityParameter { get; set;}

		[Ordinal(0)] [RED("eventsOnAttach", 2,0)] 		public CArray<StringAnsi> EventsOnAttach { get; set;}

		[Ordinal(0)] [RED("eventsOnDetach", 2,0)] 		public CArray<StringAnsi> EventsOnDetach { get; set;}

		[Ordinal(0)] [RED("banksDependency", 2,0)] 		public CArray<CName> BanksDependency { get; set;}

		[Ordinal(0)] [RED("switchesOnAttach", 2,0)] 		public CArray<SSoundSwitch> SwitchesOnAttach { get; set;}

		[Ordinal(0)] [RED("rtpcsOnAttach", 2,0)] 		public CArray<SSoundProperty> RtpcsOnAttach { get; set;}

		[Ordinal(0)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(0)] [RED("occlusionEnabled")] 		public CBool OcclusionEnabled { get; set;}

		[Ordinal(0)] [RED("isInGameMusic")] 		public CBool IsInGameMusic { get; set;}

		[Ordinal(0)] [RED("listenerOverride")] 		public CString ListenerOverride { get; set;}

		[Ordinal(0)] [RED("updateAzimuth")] 		public CBool UpdateAzimuth { get; set;}

		public CSoundEmitterComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSoundEmitterComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}