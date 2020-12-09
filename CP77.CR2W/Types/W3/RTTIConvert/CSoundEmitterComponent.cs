using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSoundEmitterComponent : CComponent
	{
		[Ordinal(1)] [RED("loopStart")] 		public StringAnsi LoopStart { get; set;}

		[Ordinal(2)] [RED("loopStop")] 		public StringAnsi LoopStop { get; set;}

		[Ordinal(3)] [RED("intensityParameter")] 		public StringAnsi IntensityParameter { get; set;}

		[Ordinal(4)] [RED("eventsOnAttach", 2,0)] 		public CArray<StringAnsi> EventsOnAttach { get; set;}

		[Ordinal(5)] [RED("eventsOnDetach", 2,0)] 		public CArray<StringAnsi> EventsOnDetach { get; set;}

		[Ordinal(6)] [RED("banksDependency", 2,0)] 		public CArray<CName> BanksDependency { get; set;}

		[Ordinal(7)] [RED("switchesOnAttach", 2,0)] 		public CArray<SSoundSwitch> SwitchesOnAttach { get; set;}

		[Ordinal(8)] [RED("rtpcsOnAttach", 2,0)] 		public CArray<SSoundProperty> RtpcsOnAttach { get; set;}

		[Ordinal(9)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(10)] [RED("occlusionEnabled")] 		public CBool OcclusionEnabled { get; set;}

		[Ordinal(11)] [RED("isInGameMusic")] 		public CBool IsInGameMusic { get; set;}

		[Ordinal(12)] [RED("listenerOverride")] 		public CString ListenerOverride { get; set;}

		[Ordinal(13)] [RED("updateAzimuth")] 		public CBool UpdateAzimuth { get; set;}

		public CSoundEmitterComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSoundEmitterComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}