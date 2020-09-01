using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSignReactiveEntity : W3MonsterClue
	{
		[Ordinal(0)] [RED("factOnSignCast")] 		public CString FactOnSignCast { get; set;}

		[Ordinal(0)] [RED("igni")] 		public CBool Igni { get; set;}

		[Ordinal(0)] [RED("aard")] 		public CBool Aard { get; set;}

		[Ordinal(0)] [RED("clueActionWhenDestroyed")] 		public CEnum<EClueOperation> ClueActionWhenDestroyed { get; set;}

		[Ordinal(0)] [RED("igniteOnInteraction")] 		public CBool IgniteOnInteraction { get; set;}

		[Ordinal(0)] [RED("destroyingTimeout")] 		public CFloat DestroyingTimeout { get; set;}

		[Ordinal(0)] [RED("destroyedEffectsTimeout")] 		public CFloat DestroyedEffectsTimeout { get; set;}

		[Ordinal(0)] [RED("destroyingEffectName")] 		public CName DestroyingEffectName { get; set;}

		[Ordinal(0)] [RED("destroyedEffectName")] 		public CName DestroyedEffectName { get; set;}

		[Ordinal(0)] [RED("isDestroyed")] 		public CBool IsDestroyed { get; set;}

		[Ordinal(0)] [RED("clueActionArray", 2,0)] 		public CArray<CEnum<EClueOperation>> ClueActionArray { get; set;}

		[Ordinal(0)] [RED("currentAppearance")] 		public CString CurrentAppearance { get; set;}

		[Ordinal(0)] [RED("interactionComponents", 2,0)] 		public CArray<CHandle<CComponent>> InteractionComponents { get; set;}

		[Ordinal(0)] [RED("i")] 		public CInt32 I { get; set;}

		public CSignReactiveEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSignReactiveEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}