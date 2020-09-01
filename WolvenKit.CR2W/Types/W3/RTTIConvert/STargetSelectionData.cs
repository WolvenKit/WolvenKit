using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class STargetSelectionData : CVariable
	{
		[Ordinal(1)] [RED("("sourcePosition")] 		public Vector SourcePosition { get; set;}

		[Ordinal(2)] [RED("("headingVector")] 		public Vector HeadingVector { get; set;}

		[Ordinal(3)] [RED("("closeDistance")] 		public CFloat CloseDistance { get; set;}

		[Ordinal(4)] [RED("("softLockDistance")] 		public CFloat SoftLockDistance { get; set;}

		public STargetSelectionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new STargetSelectionData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}