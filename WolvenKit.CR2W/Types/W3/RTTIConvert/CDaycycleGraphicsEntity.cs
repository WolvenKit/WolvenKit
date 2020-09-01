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
		[Ordinal(0)] [RED("("startStopEffects")] 		public CBool StartStopEffects { get; set;}

		[Ordinal(0)] [RED("("startStopLightsAndEngineValues")] 		public CBool StartStopLightsAndEngineValues { get; set;}

		[Ordinal(0)] [RED("("startEmissiveHour")] 		public CFloat StartEmissiveHour { get; set;}

		[Ordinal(0)] [RED("("startEmissiveFadeTime")] 		public CFloat StartEmissiveFadeTime { get; set;}

		[Ordinal(0)] [RED("("endEmissiveHour")] 		public CFloat EndEmissiveHour { get; set;}

		[Ordinal(0)] [RED("("endEmissiveFadeTime")] 		public CFloat EndEmissiveFadeTime { get; set;}

		[Ordinal(0)] [RED("("randomRange")] 		public CFloat RandomRange { get; set;}

		[Ordinal(0)] [RED("("flickeringPeriod")] 		public CFloat FlickeringPeriod { get; set;}

		[Ordinal(0)] [RED("("lightBrightnessWhenOnMin")] 		public CFloat LightBrightnessWhenOnMin { get; set;}

		[Ordinal(0)] [RED("("lightBrightnessWhenOnMax")] 		public CFloat LightBrightnessWhenOnMax { get; set;}

		[Ordinal(0)] [RED("("lightRandomOffsetX")] 		public CFloat LightRandomOffsetX { get; set;}

		[Ordinal(0)] [RED("("lightRandomOffsetY")] 		public CFloat LightRandomOffsetY { get; set;}

		[Ordinal(0)] [RED("("lightRandomOffsetZ")] 		public CFloat LightRandomOffsetZ { get; set;}

		[Ordinal(0)] [RED("("lightRadius")] 		public CFloat LightRadius { get; set;}

		[Ordinal(0)] [RED("("lightAutoHideDistance")] 		public CFloat LightAutoHideDistance { get; set;}

		[Ordinal(0)] [RED("("lightAutoHideRange")] 		public CFloat LightAutoHideRange { get; set;}

		[Ordinal(0)] [RED("("overrideRadius")] 		public CBool OverrideRadius { get; set;}

		[Ordinal(0)] [RED("("particleAlphaWhenOnMin")] 		public CFloat ParticleAlphaWhenOnMin { get; set;}

		[Ordinal(0)] [RED("("particleAlphaWhenOnMax")] 		public CFloat ParticleAlphaWhenOnMax { get; set;}

		[Ordinal(0)] [RED("("particleAlphaWhenOff")] 		public CFloat ParticleAlphaWhenOff { get; set;}

		[Ordinal(0)] [RED("("engineValueXWhenOnMin")] 		public CFloat EngineValueXWhenOnMin { get; set;}

		[Ordinal(0)] [RED("("engineValueXWhenOnMax")] 		public CFloat EngineValueXWhenOnMax { get; set;}

		[Ordinal(0)] [RED("("engineValueXWhenOff")] 		public CFloat EngineValueXWhenOff { get; set;}

		[Ordinal(0)] [RED("("engineValueYWhenOn")] 		public CFloat EngineValueYWhenOn { get; set;}

		[Ordinal(0)] [RED("("engineValueYWhenOff")] 		public CFloat EngineValueYWhenOff { get; set;}

		[Ordinal(0)] [RED("("engineValueZWhenOn")] 		public CFloat EngineValueZWhenOn { get; set;}

		[Ordinal(0)] [RED("("engineValueZWhenOff")] 		public CFloat EngineValueZWhenOff { get; set;}

		[Ordinal(0)] [RED("("engineValueWWhenOn")] 		public CFloat EngineValueWWhenOn { get; set;}

		[Ordinal(0)] [RED("("engineValueWWhenOff")] 		public CFloat EngineValueWWhenOff { get; set;}

		[Ordinal(0)] [RED("("engineValueColorWhenOn")] 		public CColor EngineValueColorWhenOn { get; set;}

		[Ordinal(0)] [RED("("engineValueColorWhenOff")] 		public CColor EngineValueColorWhenOff { get; set;}

		public CDaycycleGraphicsEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDaycycleGraphicsEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}