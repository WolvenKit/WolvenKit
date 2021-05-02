using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_KnockdownTypeApplicator : W3ApplicatorEffect
	{
		[Ordinal(1)] [RED("customEffectValue")] 		public SAbilityAttributeValue CustomEffectValue { get; set;}

		[Ordinal(2)] [RED("customDuration")] 		public CFloat CustomDuration { get; set;}

		[Ordinal(3)] [RED("customAbilityName")] 		public CName CustomAbilityName { get; set;}

		public W3Effect_KnockdownTypeApplicator(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_KnockdownTypeApplicator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}