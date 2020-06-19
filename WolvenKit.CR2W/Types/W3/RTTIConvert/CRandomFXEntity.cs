using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CRandomFXEntity : CEntity
	{
		[RED("fxName", 2,0)] 		public CArray<CName> FxName { get; set;}

		[RED("intervalMin")] 		public CFloat IntervalMin { get; set;}

		[RED("intervalMax")] 		public CFloat IntervalMax { get; set;}

		[RED("fxTwiceInARow")] 		public CBool FxTwiceInARow { get; set;}

		[RED("soundEvent")] 		public CString SoundEvent { get; set;}

		[RED("soundDelay")] 		public CFloat SoundDelay { get; set;}

		public CRandomFXEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CRandomFXEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}