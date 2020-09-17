using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSignReactiveEntity : W3MonsterClue
	{
		[Ordinal(1)] [RED("factOnSignCast")] 		public CString FactOnSignCast { get; set;}

		[Ordinal(2)] [RED("igni")] 		public CBool Igni { get; set;}

		[Ordinal(3)] [RED("aard")] 		public CBool Aard { get; set;}

		[Ordinal(4)] [RED("clueActionWhenDestroyed")] 		public CEnum<EClueOperation> ClueActionWhenDestroyed { get; set;}

		[Ordinal(5)] [RED("igniteOnInteraction")] 		public CBool IgniteOnInteraction { get; set;}

		[Ordinal(6)] [RED("destroyingTimeout")] 		public CFloat DestroyingTimeout { get; set;}

		[Ordinal(7)] [RED("destroyedEffectsTimeout")] 		public CFloat DestroyedEffectsTimeout { get; set;}

		[Ordinal(8)] [RED("destroyingEffectName")] 		public CName DestroyingEffectName { get; set;}

		[Ordinal(9)] [RED("destroyedEffectName")] 		public CName DestroyedEffectName { get; set;}

		[Ordinal(10)] [RED("isDestroyed")] 		public CBool IsDestroyed { get; set;}

		[Ordinal(11)] [RED("clueActionArray", 2,0)] 		public CArray<CEnum<EClueOperation>> ClueActionArray { get; set;}

		[Ordinal(12)] [RED("currentAppearance")] 		public CString CurrentAppearance { get; set;}

		[Ordinal(13)] [RED("interactionComponents", 2,0)] 		public CArray<CHandle<CComponent>> InteractionComponents { get; set;}

		[Ordinal(14)] [RED("i")] 		public CInt32 I { get; set;}

		public CSignReactiveEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSignReactiveEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}