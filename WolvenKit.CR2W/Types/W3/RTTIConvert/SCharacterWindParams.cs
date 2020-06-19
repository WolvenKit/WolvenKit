using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCharacterWindParams : CVariable
	{
		[RED("primaryDensity")] 		public CFloat PrimaryDensity { get; set;}

		[RED("secondaryDensity")] 		public CFloat SecondaryDensity { get; set;}

		[RED("primaryOscilationFrequency")] 		public CFloat PrimaryOscilationFrequency { get; set;}

		[RED("secondaryOscilationFrequency")] 		public CFloat SecondaryOscilationFrequency { get; set;}

		[RED("primaryDistance")] 		public CFloat PrimaryDistance { get; set;}

		[RED("secondaryDistance")] 		public CFloat SecondaryDistance { get; set;}

		[RED("gustFrequency")] 		public CFloat GustFrequency { get; set;}

		[RED("gustDistance")] 		public CFloat GustDistance { get; set;}

		public SCharacterWindParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCharacterWindParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}