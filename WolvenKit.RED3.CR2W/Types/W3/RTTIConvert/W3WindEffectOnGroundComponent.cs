using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3WindEffectOnGroundComponent : CSelfUpdatingComponent
	{
		[Ordinal(1)] [RED("maxDistanceFromGround")] 		public CFloat MaxDistanceFromGround { get; set;}

		[Ordinal(2)] [RED("activeAtStart")] 		public CBool ActiveAtStart { get; set;}

		[Ordinal(3)] [RED("playOnAnimEvent")] 		public CBool PlayOnAnimEvent { get; set;}

		[Ordinal(4)] [RED("activateOnAnimEvent")] 		public CBool ActivateOnAnimEvent { get; set;}

		[Ordinal(5)] [RED("animEvent")] 		public CName AnimEvent { get; set;}

		[Ordinal(6)] [RED("deactivateAnimEvent")] 		public CName DeactivateAnimEvent { get; set;}

		[Ordinal(7)] [RED("delayBetweenEffects")] 		public CFloat DelayBetweenEffects { get; set;}

		[Ordinal(8)] [RED("effectTemplate")] 		public CHandle<CEntityTemplate> EffectTemplate { get; set;}

		[Ordinal(9)] [RED("m_isActive")] 		public CBool M_isActive { get; set;}

		[Ordinal(10)] [RED("m_effectEntity")] 		public CHandle<CEntity> M_effectEntity { get; set;}

		[Ordinal(11)] [RED("m_collisionGroupNames", 2,0)] 		public CArray<CName> M_collisionGroupNames { get; set;}

		[Ordinal(12)] [RED("m_delayUntilNextEffect")] 		public CFloat M_delayUntilNextEffect { get; set;}

		public W3WindEffectOnGroundComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}