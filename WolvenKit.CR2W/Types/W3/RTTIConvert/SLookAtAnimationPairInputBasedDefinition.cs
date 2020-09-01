using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLookAtAnimationPairInputBasedDefinition : CVariable
	{
		[Ordinal(0)] [RED("("Input name")] 		public CString Input_name { get; set;}

		[Ordinal(0)] [RED("("Horizontal anim (additive)")] 		public CName Horizontal_anim__additive_ { get; set;}

		[Ordinal(0)] [RED("("Vertical anim (additive)")] 		public CName Vertical_anim__additive_ { get; set;}

		public SLookAtAnimationPairInputBasedDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SLookAtAnimationPairInputBasedDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}