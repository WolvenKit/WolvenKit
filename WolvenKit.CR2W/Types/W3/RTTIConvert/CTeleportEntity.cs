using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTeleportEntity : CInteractiveEntity
	{
		[RED("keyItemName")] 		public CName KeyItemName { get; set;}

		[RED("removeKeyOnUse")] 		public CBool RemoveKeyOnUse { get; set;}

		[RED("linkingMode")] 		public CBool LinkingMode { get; set;}

		[RED("keepBlackscreen")] 		public CBool KeepBlackscreen { get; set;}

		[RED("pairedTeleport")] 		public EntityHandle PairedTeleport { get; set;}

		[RED("pairedNodeTag")] 		public CName PairedNodeTag { get; set;}

		[RED("oneWayTeleport")] 		public CBool OneWayTeleport { get; set;}

		[RED("activationTime")] 		public CFloat ActivationTime { get; set;}

		[RED("factOnActivate")] 		public CString FactOnActivate { get; set;}

		[RED("factOnTeleport")] 		public CString FactOnTeleport { get; set;}

		public CTeleportEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTeleportEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}