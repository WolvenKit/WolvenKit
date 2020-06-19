using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemSoundEvent : CFXTrackItem
	{
		[RED("soundEventName")] 		public StringAnsi SoundEventName { get; set;}

		[RED("stopFadeTime")] 		public CFloat StopFadeTime { get; set;}

		[RED("isAmbient")] 		public CBool IsAmbient { get; set;}

		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("useDistanceParameter")] 		public CBool UseDistanceParameter { get; set;}

		[RED("latchDistanceParameterBelow")] 		public CFloat LatchDistanceParameterBelow { get; set;}

		[RED("invertLatchDistance")] 		public CBool InvertLatchDistance { get; set;}

		[RED("latchEvent")] 		public StringAnsi LatchEvent { get; set;}

		[RED("boneName")] 		public CName BoneName { get; set;}

		[RED("speed")] 		public CFloat Speed { get; set;}

		[RED("decelDist")] 		public CFloat DecelDist { get; set;}

		public CFXTrackItemSoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXTrackItemSoundEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}