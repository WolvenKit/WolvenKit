using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvSunAndMoonParameters : CVariable
	{
		[Ordinal(0)] [RED("("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("("sunSize")] 		public SSimpleCurve SunSize { get; set;}

		[Ordinal(0)] [RED("("sunColor")] 		public SSimpleCurve SunColor { get; set;}

		[Ordinal(0)] [RED("("sunFlareSize")] 		public SSimpleCurve SunFlareSize { get; set;}

		[Ordinal(0)] [RED("("sunFlareColor")] 		public CEnvFlareColorParameters SunFlareColor { get; set;}

		[Ordinal(0)] [RED("("moonSize")] 		public SSimpleCurve MoonSize { get; set;}

		[Ordinal(0)] [RED("("moonColor")] 		public SSimpleCurve MoonColor { get; set;}

		[Ordinal(0)] [RED("("moonFlareSize")] 		public SSimpleCurve MoonFlareSize { get; set;}

		[Ordinal(0)] [RED("("moonFlareColor")] 		public CEnvFlareColorParameters MoonFlareColor { get; set;}

		public CEnvSunAndMoonParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvSunAndMoonParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}