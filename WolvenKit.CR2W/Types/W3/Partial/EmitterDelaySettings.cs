using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta(EREDMetaInfo.REDStruct)]
	public class EmitterDelaySettings : CVariable
	{
		[RED("emitterDelay")] 		public CFloat EmitterDelay { get; set;}

		[RED("emitterDelayLow")] 		public CFloat EmitterDelayLow { get; set;}

		[RED("useEmitterDelayRange")] 		public CBool UseEmitterDelayRange { get; set;}

		[RED("useEmitterDelayOnce")] 		public CBool UseEmitterDelayOnce { get; set;}

		public EmitterDelaySettings(CR2WFile cr2w) : base(cr2w){ }

		public override CVariable Create(CR2WFile cr2w) => new EmitterDelaySettings(cr2w);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}