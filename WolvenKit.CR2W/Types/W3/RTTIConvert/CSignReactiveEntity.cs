using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSignReactiveEntity : W3MonsterClue
	{
		[RED("factOnSignCast")] 		public CString FactOnSignCast { get; set;}

		[RED("igni")] 		public CBool Igni { get; set;}

		[RED("aard")] 		public CBool Aard { get; set;}

		[RED("clueActionWhenDestroyed")] 		public CEnum<EClueOperation> ClueActionWhenDestroyed { get; set;}

		[RED("igniteOnInteraction")] 		public CBool IgniteOnInteraction { get; set;}

		[RED("destroyingTimeout")] 		public CFloat DestroyingTimeout { get; set;}

		[RED("destroyedEffectsTimeout")] 		public CFloat DestroyedEffectsTimeout { get; set;}

		[RED("destroyingEffectName")] 		public CName DestroyingEffectName { get; set;}

		[RED("destroyedEffectName")] 		public CName DestroyedEffectName { get; set;}

		public CSignReactiveEntity(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSignReactiveEntity(cr2w);

	}
}