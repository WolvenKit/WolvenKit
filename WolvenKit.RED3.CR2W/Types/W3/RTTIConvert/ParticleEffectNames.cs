using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ParticleEffectNames : CVariable
	{
		[Ordinal(1)] [RED("rightSplash")] 		public CName RightSplash { get; set;}

		[Ordinal(2)] [RED("leftSplash")] 		public CName LeftSplash { get; set;}

		[Ordinal(3)] [RED("backSplash")] 		public CName BackSplash { get; set;}

		public ParticleEffectNames(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new ParticleEffectNames(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}