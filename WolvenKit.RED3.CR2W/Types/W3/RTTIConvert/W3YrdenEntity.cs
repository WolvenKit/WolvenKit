using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3YrdenEntity : W3SignEntity
	{
		[Ordinal(1)] [RED("effects", 2,0)] 		public CArray<SYrdenEffects> Effects { get; set;}

		[Ordinal(2)] [RED("projTemplate")] 		public CHandle<CEntityTemplate> ProjTemplate { get; set;}

		[Ordinal(3)] [RED("projDestroyFxEntTemplate")] 		public CHandle<CEntityTemplate> ProjDestroyFxEntTemplate { get; set;}

		[Ordinal(4)] [RED("runeTemplates", 2,0)] 		public CArray<CHandle<CEntityTemplate>> RuneTemplates { get; set;}

		[Ordinal(5)] [RED("validTargetsInArea", 2,0)] 		public CArray<CHandle<CActor>> ValidTargetsInArea { get; set;}

		[Ordinal(6)] [RED("allActorsInArea", 2,0)] 		public CArray<CHandle<CActor>> AllActorsInArea { get; set;}

		[Ordinal(7)] [RED("flyersInArea", 2,0)] 		public CArray<CHandle<CNewNPC>> FlyersInArea { get; set;}

		[Ordinal(8)] [RED("trapDuration")] 		public CFloat TrapDuration { get; set;}

		[Ordinal(9)] [RED("charges")] 		public CInt32 Charges { get; set;}

		[Ordinal(10)] [RED("isPlayerInside")] 		public CBool IsPlayerInside { get; set;}

		[Ordinal(11)] [RED("baseModeRange")] 		public CFloat BaseModeRange { get; set;}

		[Ordinal(12)] [RED("notFromPlayerCast")] 		public CBool NotFromPlayerCast { get; set;}

		[Ordinal(13)] [RED("fxEntities", 2,0)] 		public CArray<CHandle<CEntity>> FxEntities { get; set;}

		public W3YrdenEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}