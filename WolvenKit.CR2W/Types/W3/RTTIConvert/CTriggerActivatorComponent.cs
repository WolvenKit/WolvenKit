using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTriggerActivatorComponent : CComponent
	{
		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("height")] 		public CFloat Height { get; set;}

		[RED("channels")] 		public ETriggerChannel Channels { get; set;}

		[RED("enableCCD")] 		public CBool EnableCCD { get; set;}

		[RED("maxContinousDistance")] 		public CFloat MaxContinousDistance { get; set;}

		public CTriggerActivatorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTriggerActivatorComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}