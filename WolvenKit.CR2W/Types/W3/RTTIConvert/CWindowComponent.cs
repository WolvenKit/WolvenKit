using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWindowComponent : CMeshComponent
	{
		[RED("startEmissiveHour")] 		public CFloat StartEmissiveHour { get; set;}

		[RED("startEmissiveFadeTime")] 		public CFloat StartEmissiveFadeTime { get; set;}

		[RED("endEmissiveHour")] 		public CFloat EndEmissiveHour { get; set;}

		[RED("endEmissiveFadeTime")] 		public CFloat EndEmissiveFadeTime { get; set;}

		[RED("randomRange")] 		public CFloat RandomRange { get; set;}

		public CWindowComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWindowComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}