using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3WindEffectOnGroundComponent : CSelfUpdatingComponent
	{
		[Ordinal(0)] [RED("("maxDistanceFromGround")] 		public CFloat MaxDistanceFromGround { get; set;}

		[Ordinal(0)] [RED("("activeAtStart")] 		public CBool ActiveAtStart { get; set;}

		[Ordinal(0)] [RED("("playOnAnimEvent")] 		public CBool PlayOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("activateOnAnimEvent")] 		public CBool ActivateOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("animEvent")] 		public CName AnimEvent { get; set;}

		[Ordinal(0)] [RED("("deactivateAnimEvent")] 		public CName DeactivateAnimEvent { get; set;}

		[Ordinal(0)] [RED("("delayBetweenEffects")] 		public CFloat DelayBetweenEffects { get; set;}

		[Ordinal(0)] [RED("("effectTemplate")] 		public CHandle<CEntityTemplate> EffectTemplate { get; set;}

		[Ordinal(0)] [RED("("m_isActive")] 		public CBool M_isActive { get; set;}

		[Ordinal(0)] [RED("("m_effectEntity")] 		public CHandle<CEntity> M_effectEntity { get; set;}

		[Ordinal(0)] [RED("("m_collisionGroupNames", 2,0)] 		public CArray<CName> M_collisionGroupNames { get; set;}

		[Ordinal(0)] [RED("("m_delayUntilNextEffect")] 		public CFloat M_delayUntilNextEffect { get; set;}

		public W3WindEffectOnGroundComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3WindEffectOnGroundComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}