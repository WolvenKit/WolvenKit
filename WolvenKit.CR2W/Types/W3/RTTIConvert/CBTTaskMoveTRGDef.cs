using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMoveTRGDef : IBehTreeTaskDefinition
	{
		[RED("fleeDistance")] 		public CFloat FleeDistance { get; set;}

		[RED("activationDistance")] 		public CFloat ActivationDistance { get; set;}

		[RED("ignoreEntityWithTag")] 		public CName IgnoreEntityWithTag { get; set;}

		[RED("flee")] 		public CBool Flee { get; set;}

		public CBTTaskMoveTRGDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskMoveTRGDef(cr2w);

	}
}