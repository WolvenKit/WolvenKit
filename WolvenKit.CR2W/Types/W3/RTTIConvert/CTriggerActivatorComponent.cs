using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTriggerActivatorComponent : CComponent
	{
		[Ordinal(1)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(2)] [RED("height")] 		public CFloat Height { get; set;}

		[Ordinal(3)] [RED("channels")] 		public CEnum<ETriggerChannel> Channels { get; set;}

		[Ordinal(4)] [RED("enableCCD")] 		public CBool EnableCCD { get; set;}

		[Ordinal(5)] [RED("maxContinousDistance")] 		public CFloat MaxContinousDistance { get; set;}

		public CTriggerActivatorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTriggerActivatorComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}