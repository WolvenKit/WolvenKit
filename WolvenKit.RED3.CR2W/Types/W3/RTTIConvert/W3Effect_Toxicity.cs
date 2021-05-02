using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_Toxicity : CBaseGameplayEffect
	{
		[Ordinal(1)] [RED("dmgTypeName")] 		public CName DmgTypeName { get; set;}

		[Ordinal(2)] [RED("toxThresholdEffect")] 		public CInt32 ToxThresholdEffect { get; set;}

		[Ordinal(3)] [RED("delayToNextVFXUpdate")] 		public CFloat DelayToNextVFXUpdate { get; set;}

		public W3Effect_Toxicity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_Toxicity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}