using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SQuenEffects : CVariable
	{
		[RED("lastingEffectUpgNone")] 		public CName LastingEffectUpgNone { get; set;}

		[RED("lastingEffectUpg1")] 		public CName LastingEffectUpg1 { get; set;}

		[RED("lastingEffectUpg2")] 		public CName LastingEffectUpg2 { get; set;}

		[RED("lastingEffectUpg3")] 		public CName LastingEffectUpg3 { get; set;}

		[RED("castEffect")] 		public CName CastEffect { get; set;}

		[RED("cameraShakeStranth")] 		public CFloat CameraShakeStranth { get; set;}

		public SQuenEffects(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SQuenEffects(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}