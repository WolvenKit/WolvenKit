using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_Toxicity : CBaseGameplayEffect
	{
		[Ordinal(0)] [RED("("dmgTypeName")] 		public CName DmgTypeName { get; set;}

		[Ordinal(0)] [RED("("toxThresholdEffect")] 		public CInt32 ToxThresholdEffect { get; set;}

		[Ordinal(0)] [RED("("delayToNextVFXUpdate")] 		public CFloat DelayToNextVFXUpdate { get; set;}

		public W3Effect_Toxicity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_Toxicity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}