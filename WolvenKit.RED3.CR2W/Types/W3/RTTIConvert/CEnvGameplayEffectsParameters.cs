using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvGameplayEffectsParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("catEffectBrightnessMultiply")] 		public SSimpleCurve CatEffectBrightnessMultiply { get; set;}

		[Ordinal(3)] [RED("behaviorAnimationMultiplier")] 		public SSimpleCurve BehaviorAnimationMultiplier { get; set;}

		[Ordinal(4)] [RED("specularityMultiplier")] 		public SSimpleCurve SpecularityMultiplier { get; set;}

		[Ordinal(5)] [RED("glossinessMultiplier")] 		public SSimpleCurve GlossinessMultiplier { get; set;}

		public CEnvGameplayEffectsParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvGameplayEffectsParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}