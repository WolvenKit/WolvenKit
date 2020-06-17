using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraEffectTrigger : CGameplayEntity
	{
		[RED("isPlayingEffect")] 		public CBool IsPlayingEffect { get; set;}

		[RED("effectName")] 		public CName EffectName { get; set;}

		[RED("useSharedEffects")] 		public CBool UseSharedEffects { get; set;}

		[RED("effectEntityPosition")] 		public EEffectEntityPosition EffectEntityPosition { get; set;}

		[RED("effectEntityRotation")] 		public EEffectEntityRotation EffectEntityRotation { get; set;}

		[RED("effectEntityOffset")] 		public Vector3 EffectEntityOffset { get; set;}

		[RED("playFrom")] 		public GameTime PlayFrom { get; set;}

		[RED("playTo")] 		public GameTime PlayTo { get; set;}

		public CCameraEffectTrigger(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CCameraEffectTrigger(cr2w);

	}
}