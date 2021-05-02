using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDaycycleGraphicsEntity : CEntity
	{
		[Ordinal(1)] [RED("startStopEffects")] 		public CBool StartStopEffects { get; set;}

		[Ordinal(2)] [RED("startStopLightsAndEngineValues")] 		public CBool StartStopLightsAndEngineValues { get; set;}

		[Ordinal(3)] [RED("startEmissiveHour")] 		public CFloat StartEmissiveHour { get; set;}

		[Ordinal(4)] [RED("startEmissiveFadeTime")] 		public CFloat StartEmissiveFadeTime { get; set;}

		[Ordinal(5)] [RED("endEmissiveHour")] 		public CFloat EndEmissiveHour { get; set;}

		[Ordinal(6)] [RED("endEmissiveFadeTime")] 		public CFloat EndEmissiveFadeTime { get; set;}

		[Ordinal(7)] [RED("randomRange")] 		public CFloat RandomRange { get; set;}

		[Ordinal(8)] [RED("flickeringPeriod")] 		public CFloat FlickeringPeriod { get; set;}

		[Ordinal(9)] [RED("lightBrightnessWhenOnMin")] 		public CFloat LightBrightnessWhenOnMin { get; set;}

		[Ordinal(10)] [RED("lightBrightnessWhenOnMax")] 		public CFloat LightBrightnessWhenOnMax { get; set;}

		[Ordinal(11)] [RED("lightRandomOffsetX")] 		public CFloat LightRandomOffsetX { get; set;}

		[Ordinal(12)] [RED("lightRandomOffsetY")] 		public CFloat LightRandomOffsetY { get; set;}

		[Ordinal(13)] [RED("lightRandomOffsetZ")] 		public CFloat LightRandomOffsetZ { get; set;}

		[Ordinal(14)] [RED("lightRadius")] 		public CFloat LightRadius { get; set;}

		[Ordinal(15)] [RED("lightAutoHideDistance")] 		public CFloat LightAutoHideDistance { get; set;}

		[Ordinal(16)] [RED("lightAutoHideRange")] 		public CFloat LightAutoHideRange { get; set;}

		[Ordinal(17)] [RED("overrideRadius")] 		public CBool OverrideRadius { get; set;}

		[Ordinal(18)] [RED("particleAlphaWhenOnMin")] 		public CFloat ParticleAlphaWhenOnMin { get; set;}

		[Ordinal(19)] [RED("particleAlphaWhenOnMax")] 		public CFloat ParticleAlphaWhenOnMax { get; set;}

		[Ordinal(20)] [RED("particleAlphaWhenOff")] 		public CFloat ParticleAlphaWhenOff { get; set;}

		[Ordinal(21)] [RED("engineValueXWhenOnMin")] 		public CFloat EngineValueXWhenOnMin { get; set;}

		[Ordinal(22)] [RED("engineValueXWhenOnMax")] 		public CFloat EngineValueXWhenOnMax { get; set;}

		[Ordinal(23)] [RED("engineValueXWhenOff")] 		public CFloat EngineValueXWhenOff { get; set;}

		[Ordinal(24)] [RED("engineValueYWhenOn")] 		public CFloat EngineValueYWhenOn { get; set;}

		[Ordinal(25)] [RED("engineValueYWhenOff")] 		public CFloat EngineValueYWhenOff { get; set;}

		[Ordinal(26)] [RED("engineValueZWhenOn")] 		public CFloat EngineValueZWhenOn { get; set;}

		[Ordinal(27)] [RED("engineValueZWhenOff")] 		public CFloat EngineValueZWhenOff { get; set;}

		[Ordinal(28)] [RED("engineValueWWhenOn")] 		public CFloat EngineValueWWhenOn { get; set;}

		[Ordinal(29)] [RED("engineValueWWhenOff")] 		public CFloat EngineValueWWhenOff { get; set;}

		[Ordinal(30)] [RED("engineValueColorWhenOn")] 		public CColor EngineValueColorWhenOn { get; set;}

		[Ordinal(31)] [RED("engineValueColorWhenOff")] 		public CColor EngineValueColorWhenOff { get; set;}

		public CDaycycleGraphicsEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDaycycleGraphicsEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}