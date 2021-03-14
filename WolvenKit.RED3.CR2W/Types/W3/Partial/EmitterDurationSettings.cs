using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta()]
	public class EmitterDurationSettings : CVariable
	{
		[Ordinal(1)] [RED("emitterDuration")] 		public CFloat EmitterDuration { get; set;}

		[Ordinal(2)] [RED("emitterDurationLow")] 		public CFloat EmitterDurationLow { get; set;}

		[Ordinal(3)] [RED("useEmitterDurationRange")] 		public CBool UseEmitterDurationRange { get; set;}

		public EmitterDurationSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new EmitterDurationSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}