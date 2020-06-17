using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFollowOwnerTRGDef : IBehTreeTaskDefinition
	{
		[RED("activationDistance")] 		public CFloat ActivationDistance { get; set;}

		[RED("minimumDistance")] 		public CFloat MinimumDistance { get; set;}

		[RED("ignoreEntityWithTag")] 		public CName IgnoreEntityWithTag { get; set;}

		public CBTTaskFollowOwnerTRGDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskFollowOwnerTRGDef(cr2w);

	}
}