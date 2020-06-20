using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWeatherBonus : CVariable
	{
		[RED("dayPart")] 		public CEnum<EDayPart> DayPart { get; set;}

		[RED("weather")] 		public CEnum<EWeatherEffect> Weather { get; set;}

		[RED("moonState")] 		public CEnum<EMoonState> MoonState { get; set;}

		[RED("ability")] 		public CName Ability { get; set;}

		public SWeatherBonus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SWeatherBonus(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}