using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCharacterWindParams : CVariable
	{
		[Ordinal(0)] [RED("("primaryDensity")] 		public CFloat PrimaryDensity { get; set;}

		[Ordinal(0)] [RED("("secondaryDensity")] 		public CFloat SecondaryDensity { get; set;}

		[Ordinal(0)] [RED("("primaryOscilationFrequency")] 		public CFloat PrimaryOscilationFrequency { get; set;}

		[Ordinal(0)] [RED("("secondaryOscilationFrequency")] 		public CFloat SecondaryOscilationFrequency { get; set;}

		[Ordinal(0)] [RED("("primaryDistance")] 		public CFloat PrimaryDistance { get; set;}

		[Ordinal(0)] [RED("("secondaryDistance")] 		public CFloat SecondaryDistance { get; set;}

		[Ordinal(0)] [RED("("gustFrequency")] 		public CFloat GustFrequency { get; set;}

		[Ordinal(0)] [RED("("gustDistance")] 		public CFloat GustDistance { get; set;}

		public SCharacterWindParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCharacterWindParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}