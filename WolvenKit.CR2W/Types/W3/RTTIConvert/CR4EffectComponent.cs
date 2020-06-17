using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4EffectComponent : CComponent
	{
		[RED("effectName")] 		public CName EffectName { get; set;}

		[RED("effectTarget")] 		public EntityHandle EffectTarget { get; set;}

		[RED("targetBone")] 		public CName TargetBone { get; set;}

		public CR4EffectComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CR4EffectComponent(cr2w);

	}
}