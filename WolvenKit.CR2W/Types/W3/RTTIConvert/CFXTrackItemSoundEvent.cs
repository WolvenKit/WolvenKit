using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemSoundEvent : CFXTrackItem
	{
		[Ordinal(1)] [RED("("soundEventName")] 		public StringAnsi SoundEventName { get; set;}

		[Ordinal(2)] [RED("("stopFadeTime")] 		public CFloat StopFadeTime { get; set;}

		[Ordinal(3)] [RED("("isAmbient")] 		public CBool IsAmbient { get; set;}

		[Ordinal(4)] [RED("("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(5)] [RED("("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(6)] [RED("("useDistanceParameter")] 		public CBool UseDistanceParameter { get; set;}

		[Ordinal(7)] [RED("("latchDistanceParameterBelow")] 		public CFloat LatchDistanceParameterBelow { get; set;}

		[Ordinal(8)] [RED("("invertLatchDistance")] 		public CBool InvertLatchDistance { get; set;}

		[Ordinal(9)] [RED("("latchEvent")] 		public StringAnsi LatchEvent { get; set;}

		[Ordinal(10)] [RED("("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(11)] [RED("("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(12)] [RED("("decelDist")] 		public CFloat DecelDist { get; set;}

		public CFXTrackItemSoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXTrackItemSoundEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}