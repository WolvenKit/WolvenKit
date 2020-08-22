using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDaycycleGraphicsEntity : CEntity
	{
		[RED("startStopEffects")] 		public CBool StartStopEffects { get; set;}

		[RED("startStopLightsAndEngineValues")] 		public CBool StartStopLightsAndEngineValues { get; set;}

		[RED("startEmissiveHour")] 		public CFloat StartEmissiveHour { get; set;}

		[RED("startEmissiveFadeTime")] 		public CFloat StartEmissiveFadeTime { get; set;}

		[RED("endEmissiveHour")] 		public CFloat EndEmissiveHour { get; set;}

		[RED("endEmissiveFadeTime")] 		public CFloat EndEmissiveFadeTime { get; set;}

		[RED("randomRange")] 		public CFloat RandomRange { get; set;}

		[RED("flickeringPeriod")] 		public CFloat FlickeringPeriod { get; set;}

		[RED("lightBrightnessWhenOnMin")] 		public CFloat LightBrightnessWhenOnMin { get; set;}

		[RED("lightBrightnessWhenOnMax")] 		public CFloat LightBrightnessWhenOnMax { get; set;}

		[RED("lightRandomOffsetX")] 		public CFloat LightRandomOffsetX { get; set;}

		[RED("lightRandomOffsetY")] 		public CFloat LightRandomOffsetY { get; set;}

		[RED("lightRandomOffsetZ")] 		public CFloat LightRandomOffsetZ { get; set;}

		[RED("lightRadius")] 		public CFloat LightRadius { get; set;}

		[RED("lightAutoHideDistance")] 		public CFloat LightAutoHideDistance { get; set;}

		[RED("lightAutoHideRange")] 		public CFloat LightAutoHideRange { get; set;}

		[RED("overrideRadius")] 		public CBool OverrideRadius { get; set;}

		[RED("particleAlphaWhenOnMin")] 		public CFloat ParticleAlphaWhenOnMin { get; set;}

		[RED("particleAlphaWhenOnMax")] 		public CFloat ParticleAlphaWhenOnMax { get; set;}

		[RED("particleAlphaWhenOff")] 		public CFloat ParticleAlphaWhenOff { get; set;}

		[RED("engineValueXWhenOnMin")] 		public CFloat EngineValueXWhenOnMin { get; set;}

		[RED("engineValueXWhenOnMax")] 		public CFloat EngineValueXWhenOnMax { get; set;}

		[RED("engineValueXWhenOff")] 		public CFloat EngineValueXWhenOff { get; set;}

		[RED("engineValueYWhenOn")] 		public CFloat EngineValueYWhenOn { get; set;}

		[RED("engineValueYWhenOff")] 		public CFloat EngineValueYWhenOff { get; set;}

		[RED("engineValueZWhenOn")] 		public CFloat EngineValueZWhenOn { get; set;}

		[RED("engineValueZWhenOff")] 		public CFloat EngineValueZWhenOff { get; set;}

		[RED("engineValueWWhenOn")] 		public CFloat EngineValueWWhenOn { get; set;}

		[RED("engineValueWWhenOff")] 		public CFloat EngineValueWWhenOff { get; set;}

		[RED("engineValueColorWhenOn")] 		public CColor EngineValueColorWhenOn { get; set;}

		[RED("engineValueColorWhenOff")] 		public CColor EngineValueColorWhenOff { get; set;}

		public CDaycycleGraphicsEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDaycycleGraphicsEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}