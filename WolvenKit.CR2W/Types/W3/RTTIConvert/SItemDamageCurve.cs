using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SItemDamageCurve : CVariable
	{
		[RED("term1")] 		public CFloat Term1 { get; set;}

		[RED("term2")] 		public CFloat Term2 { get; set;}

		[RED("term3")] 		public CFloat Term3 { get; set;}

		public SItemDamageCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SItemDamageCurve(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}