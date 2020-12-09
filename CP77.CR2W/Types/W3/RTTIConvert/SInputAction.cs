using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SInputAction : CVariable
	{
		[Ordinal(1)] [RED("aName")] 		public CName AName { get; set;}

		[Ordinal(2)] [RED("value")] 		public CFloat Value { get; set;}

		[Ordinal(3)] [RED("lastFrameValue")] 		public CFloat LastFrameValue { get; set;}

		public SInputAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SInputAction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}