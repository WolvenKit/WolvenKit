using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMapPinType : CVariable
	{
		[RED("typeName")] 		public CName TypeName { get; set;}

		[RED("icon")] 		public CString Icon { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("color")] 		public CColor Color { get; set;}

		public SMapPinType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMapPinType(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}