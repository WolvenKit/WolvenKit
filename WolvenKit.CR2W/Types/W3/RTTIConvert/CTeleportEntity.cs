using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTeleportEntity : CInteractiveEntity
	{
		[Ordinal(0)] [RED("("keyItemName")] 		public CName KeyItemName { get; set;}

		[Ordinal(0)] [RED("("removeKeyOnUse")] 		public CBool RemoveKeyOnUse { get; set;}

		[Ordinal(0)] [RED("("linkingMode")] 		public CBool LinkingMode { get; set;}

		[Ordinal(0)] [RED("("keepBlackscreen")] 		public CBool KeepBlackscreen { get; set;}

		[Ordinal(0)] [RED("("pairedTeleport")] 		public EntityHandle PairedTeleport { get; set;}

		[Ordinal(0)] [RED("("pairedNodeTag")] 		public CName PairedNodeTag { get; set;}

		[Ordinal(0)] [RED("("oneWayTeleport")] 		public CBool OneWayTeleport { get; set;}

		[Ordinal(0)] [RED("("activationTime")] 		public CFloat ActivationTime { get; set;}

		[Ordinal(0)] [RED("("factOnActivate")] 		public CString FactOnActivate { get; set;}

		[Ordinal(0)] [RED("("factOnTeleport")] 		public CString FactOnTeleport { get; set;}

		[Ordinal(0)] [RED("("factOnActivateValidFor")] 		public CInt32 FactOnActivateValidFor { get; set;}

		[Ordinal(0)] [RED("("factOnTeleportValidFor")] 		public CInt32 FactOnTeleportValidFor { get; set;}

		[Ordinal(0)] [RED("("isActivated")] 		public CBool IsActivated { get; set;}

		[Ordinal(0)] [RED("("destinationNode")] 		public CHandle<CNode> DestinationNode { get; set;}

		[Ordinal(0)] [RED("("currentlyTeleporting")] 		public CBool CurrentlyTeleporting { get; set;}

		public CTeleportEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTeleportEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}