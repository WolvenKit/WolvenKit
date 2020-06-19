using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvSunAndMoonParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("sunSize")] 		public SSimpleCurve SunSize { get; set;}

		[RED("sunColor")] 		public SSimpleCurve SunColor { get; set;}

		[RED("sunFlareSize")] 		public SSimpleCurve SunFlareSize { get; set;}

		[RED("sunFlareColor")] 		public CEnvFlareColorParameters SunFlareColor { get; set;}

		[RED("moonSize")] 		public SSimpleCurve MoonSize { get; set;}

		[RED("moonColor")] 		public SSimpleCurve MoonColor { get; set;}

		[RED("moonFlareSize")] 		public SSimpleCurve MoonFlareSize { get; set;}

		[RED("moonFlareColor")] 		public CEnvFlareColorParameters MoonFlareColor { get; set;}

		public CEnvSunAndMoonParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvSunAndMoonParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}