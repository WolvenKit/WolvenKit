using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCommonMapPinInstance : CVariable
	{
		[RED("id")] 		public CInt32 Id { get; set;}

		[RED("tag")] 		public CName Tag { get; set;}

		[RED("customNameId")] 		public CInt32 CustomNameId { get; set;}

		[RED("extraTag")] 		public CName ExtraTag { get; set;}

		[RED("type")] 		public CName Type { get; set;}

		[RED("visibleType")] 		public CName VisibleType { get; set;}

		[RED("alternateVersion")] 		public CInt32 AlternateVersion { get; set;}

		[RED("position")] 		public Vector Position { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("visibleRadius")] 		public CFloat VisibleRadius { get; set;}

		[RED("guid")] 		public CGUID Guid { get; set;}

		[RED("entities", 2,0)] 		public CArray<CHandle<CEntity>> Entities { get; set;}

		[RED("isDynamic")] 		public CBool IsDynamic { get; set;}

		[RED("isKnown")] 		public CBool IsKnown { get; set;}

		[RED("isDiscovered")] 		public CBool IsDiscovered { get; set;}

		[RED("isDisabled")] 		public CBool IsDisabled { get; set;}

		[RED("isHighlightable")] 		public CBool IsHighlightable { get; set;}

		[RED("isHighlighted")] 		public CBool IsHighlighted { get; set;}

		[RED("canBePointedByArrow")] 		public CBool CanBePointedByArrow { get; set;}

		[RED("canBeAddedToMinimap")] 		public CBool CanBeAddedToMinimap { get; set;}

		[RED("isAddedToMinimap")] 		public CBool IsAddedToMinimap { get; set;}

		[RED("invalidated")] 		public CBool Invalidated { get; set;}

		public SCommonMapPinInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCommonMapPinInstance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}