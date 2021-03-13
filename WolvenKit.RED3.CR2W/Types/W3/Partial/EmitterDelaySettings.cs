using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta()]
	public class EmitterDelaySettings : CVariable
	{
		[Ordinal(1)] [RED("emitterDelay")] 		public CFloat EmitterDelay { get; set;}

		[Ordinal(2)] [RED("emitterDelayLow")] 		public CFloat EmitterDelayLow { get; set;}

		[Ordinal(3)] [RED("useEmitterDelayRange")] 		public CBool UseEmitterDelayRange { get; set;}

		[Ordinal(4)] [RED("useEmitterDelayOnce")] 		public CBool UseEmitterDelayOnce { get; set;}

		public EmitterDelaySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new EmitterDelaySettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}