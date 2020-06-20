using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CriticalStateTrap : CInteractiveEntity
	{
		[RED("effectOnSpawn")] 		public CName EffectOnSpawn { get; set;}

		[RED("effectToPlayOnActivation")] 		public CName EffectToPlayOnActivation { get; set;}

		[RED("durationFrom")] 		public CInt32 DurationFrom { get; set;}

		[RED("durationTo")] 		public CInt32 DurationTo { get; set;}

		public W3CriticalStateTrap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3CriticalStateTrap(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}