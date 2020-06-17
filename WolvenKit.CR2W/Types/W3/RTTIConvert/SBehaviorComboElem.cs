using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorComboElem : CVariable
	{
		[RED("animations", 2,0)] 		public CArray<SBehaviorComboAnim> Animations { get; set;}

		[RED("enum")] 		public CName Enum { get; set;}

		public SBehaviorComboElem(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SBehaviorComboElem(cr2w);

	}
}