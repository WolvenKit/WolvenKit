using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLookAtAnimationPairDefinition : CVariable
	{
		[RED("Animation name")] 		public CName Animation_name { get; set;}

		[RED("Horizontal anim (additive)")] 		public CName Horizontal_anim__additive_ { get; set;}

		[RED("Vertical anim (additive)")] 		public CName Vertical_anim__additive_ { get; set;}

		public SLookAtAnimationPairDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SLookAtAnimationPairDefinition(cr2w);

	}
}