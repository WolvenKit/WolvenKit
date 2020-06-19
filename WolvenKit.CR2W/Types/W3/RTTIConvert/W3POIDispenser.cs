using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3POIDispenser : CGameplayEntity
	{
		[RED("pointsTag")] 		public CName PointsTag { get; set;}

		[RED("onExitDespawnAllAfter")] 		public CInt32 OnExitDespawnAllAfter { get; set;}

		[RED("shouldUseRandomRespawnTime")] 		public CBool ShouldUseRandomRespawnTime { get; set;}

		[RED("respawnInterval")] 		public CFloat RespawnInterval { get; set;}

		[RED("poiEntity")] 		public W3POIEntities PoiEntity { get; set;}

		public W3POIDispenser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3POIDispenser(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}