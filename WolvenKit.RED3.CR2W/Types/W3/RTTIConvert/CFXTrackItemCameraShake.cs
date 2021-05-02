using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemCameraShake : CFXTrackItem
	{
		[Ordinal(1)] [RED("effectFullForceRadius")] 		public CFloat EffectFullForceRadius { get; set;}

		[Ordinal(2)] [RED("effectMaxRadius")] 		public CFloat EffectMaxRadius { get; set;}

		[Ordinal(3)] [RED("shakeType")] 		public CName ShakeType { get; set;}

		public CFXTrackItemCameraShake(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXTrackItemCameraShake(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}