using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CRandomFXEntity : CEntity
	{
		[Ordinal(0)] [RED("("fxName", 2,0)] 		public CArray<CName> FxName { get; set;}

		[Ordinal(0)] [RED("("intervalMin")] 		public CFloat IntervalMin { get; set;}

		[Ordinal(0)] [RED("("intervalMax")] 		public CFloat IntervalMax { get; set;}

		[Ordinal(0)] [RED("("fxTwiceInARow")] 		public CBool FxTwiceInARow { get; set;}

		[Ordinal(0)] [RED("("soundEvent")] 		public CString SoundEvent { get; set;}

		[Ordinal(0)] [RED("("soundDelay")] 		public CFloat SoundDelay { get; set;}

		[Ordinal(0)] [RED("("fxIndex")] 		public CInt32 FxIndex { get; set;}

		[Ordinal(0)] [RED("("size")] 		public CInt32 Size { get; set;}

		[Ordinal(0)] [RED("("interval")] 		public CFloat Interval { get; set;}

		public CRandomFXEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CRandomFXEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}