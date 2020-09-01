using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemPlayPropertyAnim : CFXTrackItem
	{
		[Ordinal(0)] [RED("("propertyAnimationName")] 		public CName PropertyAnimationName { get; set;}

		[Ordinal(0)] [RED("("restoreAtEnd")] 		public CBool RestoreAtEnd { get; set;}

		[Ordinal(0)] [RED("("loopCount")] 		public CUInt32 LoopCount { get; set;}

		public CFXTrackItemPlayPropertyAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXTrackItemPlayPropertyAnim(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}