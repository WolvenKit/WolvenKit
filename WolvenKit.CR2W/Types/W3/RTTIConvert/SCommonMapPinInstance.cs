using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCommonMapPinInstance : CVariable
	{
		[Ordinal(1)] [RED("id")] 		public CInt32 Id { get; set;}

		[Ordinal(2)] [RED("tag")] 		public CName Tag { get; set;}

		[Ordinal(3)] [RED("customNameId")] 		public CInt32 CustomNameId { get; set;}

		[Ordinal(4)] [RED("extraTag")] 		public CName ExtraTag { get; set;}

		[Ordinal(5)] [RED("type")] 		public CName Type { get; set;}

		[Ordinal(6)] [RED("visibleType")] 		public CName VisibleType { get; set;}

		[Ordinal(7)] [RED("alternateVersion")] 		public CInt32 AlternateVersion { get; set;}

		[Ordinal(8)] [RED("position")] 		public Vector Position { get; set;}

		[Ordinal(9)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(10)] [RED("visibleRadius")] 		public CFloat VisibleRadius { get; set;}

		[Ordinal(11)] [RED("guid")] 		public CGUID Guid { get; set;}

		[Ordinal(12)] [RED("entities", 2,0)] 		public CArray<CHandle<CEntity>> Entities { get; set;}

		[Ordinal(13)] [RED("isDynamic")] 		public CBool IsDynamic { get; set;}

		[Ordinal(14)] [RED("isKnown")] 		public CBool IsKnown { get; set;}

		[Ordinal(15)] [RED("isDiscovered")] 		public CBool IsDiscovered { get; set;}

		[Ordinal(16)] [RED("isDisabled")] 		public CBool IsDisabled { get; set;}

		[Ordinal(17)] [RED("isHighlightable")] 		public CBool IsHighlightable { get; set;}

		[Ordinal(18)] [RED("isHighlighted")] 		public CBool IsHighlighted { get; set;}

		[Ordinal(19)] [RED("canBePointedByArrow")] 		public CBool CanBePointedByArrow { get; set;}

		[Ordinal(20)] [RED("canBeAddedToMinimap")] 		public CBool CanBeAddedToMinimap { get; set;}

		[Ordinal(21)] [RED("isAddedToMinimap")] 		public CBool IsAddedToMinimap { get; set;}

		[Ordinal(22)] [RED("invalidated")] 		public CBool Invalidated { get; set;}

		public SCommonMapPinInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCommonMapPinInstance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}