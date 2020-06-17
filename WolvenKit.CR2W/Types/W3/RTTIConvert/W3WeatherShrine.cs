using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3WeatherShrine : CGameplayEntity
	{
		[RED("weatherBlendTime")] 		public CFloat WeatherBlendTime { get; set;}

		[RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[RED("prayerForSunAcceptedFX")] 		public CName PrayerForSunAcceptedFX { get; set;}

		[RED("prayerForStormAcceptedFX")] 		public CName PrayerForStormAcceptedFX { get; set;}

		[RED("price")] 		public CInt32 Price { get; set;}

		public W3WeatherShrine(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3WeatherShrine(cr2w);

	}
}