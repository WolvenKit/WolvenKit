using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemCameraShake : CFXTrackItem
	{
		[Ordinal(0)] [RED("effectFullForceRadius")] 		public CFloat EffectFullForceRadius { get; set;}

		[Ordinal(0)] [RED("effectMaxRadius")] 		public CFloat EffectMaxRadius { get; set;}

		[Ordinal(0)] [RED("shakeType")] 		public CName ShakeType { get; set;}

		public CFXTrackItemCameraShake(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXTrackItemCameraShake(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}