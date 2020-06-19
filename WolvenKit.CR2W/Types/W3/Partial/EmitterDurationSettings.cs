using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta(EREDMetaInfo.REDStruct)]
	public class EmitterDurationSettings : CVariable
	{
		[RED("emitterDuration")] 		public CFloat EmitterDuration { get; set;}

		[RED("emitterDurationLow")] 		public CFloat EmitterDurationLow { get; set;}

		[RED("useEmitterDurationRange")] 		public CBool UseEmitterDurationRange { get; set;}

		public EmitterDurationSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new EmitterDurationSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}