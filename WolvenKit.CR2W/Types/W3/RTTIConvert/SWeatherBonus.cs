using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWeatherBonus : CVariable
	{
		[RED("dayPart")] 		public EDayPart DayPart { get; set;}

		[RED("weather")] 		public EWeatherEffect Weather { get; set;}

		[RED("moonState")] 		public EMoonState MoonState { get; set;}

		[RED("ability")] 		public CName Ability { get; set;}

		public SWeatherBonus(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SWeatherBonus(cr2w);

	}
}