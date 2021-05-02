using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4EffectComponent : CComponent
	{
		[Ordinal(1)] [RED("effectName")] 		public CName EffectName { get; set;}

		[Ordinal(2)] [RED("effectTarget")] 		public EntityHandle EffectTarget { get; set;}

		[Ordinal(3)] [RED("targetBone")] 		public CName TargetBone { get; set;}

		public CR4EffectComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}