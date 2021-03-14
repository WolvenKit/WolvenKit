using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraEffectTrigger : CGameplayEntity
	{
		[Ordinal(1)] [RED("isPlayingEffect")] 		public CBool IsPlayingEffect { get; set;}

		[Ordinal(2)] [RED("effectName")] 		public CName EffectName { get; set;}

		[Ordinal(3)] [RED("useSharedEffects")] 		public CBool UseSharedEffects { get; set;}

		[Ordinal(4)] [RED("effectEntityPosition")] 		public CEnum<EEffectEntityPosition> EffectEntityPosition { get; set;}

		[Ordinal(5)] [RED("effectEntityRotation")] 		public CEnum<EEffectEntityRotation> EffectEntityRotation { get; set;}

		[Ordinal(6)] [RED("effectEntityOffset")] 		public Vector3 EffectEntityOffset { get; set;}

		[Ordinal(7)] [RED("playFrom")] 		public GameTime PlayFrom { get; set;}

		[Ordinal(8)] [RED("playTo")] 		public GameTime PlayTo { get; set;}

		public CCameraEffectTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraEffectTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}