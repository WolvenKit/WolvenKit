using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3YrdenEntity : W3SignEntity
	{
		[RED("effects", 2,0)] 		public CArray<SYrdenEffects> Effects { get; set;}

		[RED("projTemplate")] 		public CHandle<CEntityTemplate> ProjTemplate { get; set;}

		[RED("projDestroyFxEntTemplate")] 		public CHandle<CEntityTemplate> ProjDestroyFxEntTemplate { get; set;}

		[RED("runeTemplates", 2,0)] 		public CArray<CHandle<CEntityTemplate>> RuneTemplates { get; set;}

		[RED("validTargetsInArea", 2,0)] 		public CArray<CHandle<CActor>> ValidTargetsInArea { get; set;}

		[RED("allActorsInArea", 2,0)] 		public CArray<CHandle<CActor>> AllActorsInArea { get; set;}

		[RED("flyersInArea", 2,0)] 		public CArray<CHandle<CNewNPC>> FlyersInArea { get; set;}

		[RED("trapDuration")] 		public CFloat TrapDuration { get; set;}

		[RED("charges")] 		public CInt32 Charges { get; set;}

		[RED("isPlayerInside")] 		public CBool IsPlayerInside { get; set;}

		[RED("baseModeRange")] 		public CFloat BaseModeRange { get; set;}

		[RED("notFromPlayerCast")] 		public CBool NotFromPlayerCast { get; set;}

		[RED("fxEntities", 2,0)] 		public CArray<CHandle<CEntity>> FxEntities { get; set;}

		public W3YrdenEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3YrdenEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}