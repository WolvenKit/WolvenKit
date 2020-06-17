using System.IO;using System.Runtime.Serialization;
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

		public CTriggerActivatorComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CTriggerActivatorComponent(cr2w);

	}
}