using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAxiiEffects : CVariable
	{
		[RED("castEffect")] 		public CName CastEffect { get; set;}

		[RED("throwEffect")] 		public CName ThrowEffect { get; set;}

		public SAxiiEffects(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SAxiiEffects(cr2w);

	}
}