using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SItemGenericStat : CVariable
	{
		[RED("statName")] 		public CString StatName { get; set;}

		[RED("value")] 		public CFloat Value { get; set;}

		[RED("comparence")] 		public CString Comparence { get; set;}

		public SItemGenericStat(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SItemGenericStat(cr2w);

	}
}