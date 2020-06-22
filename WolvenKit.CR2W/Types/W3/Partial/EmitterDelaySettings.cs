using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta()]
	public class EmitterDelaySettings : CVariable
	{
		[RED("emitterDelay")] 		public CFloat EmitterDelay { get; set;}

		[RED("emitterDelayLow")] 		public CFloat EmitterDelayLow { get; set;}

		[RED("useEmitterDelayRange")] 		public CBool UseEmitterDelayRange { get; set;}

		[RED("useEmitterDelayOnce")] 		public CBool UseEmitterDelayOnce { get; set;}

		public EmitterDelaySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new EmitterDelaySettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}