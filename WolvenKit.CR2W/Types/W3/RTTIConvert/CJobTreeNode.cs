using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJobTreeNode : CObject
	{
		[RED("onEnterAction")] 		public CPtr<CJobAction> OnEnterAction { get; set;}

		[RED("onLeaveAction")] 		public CPtr<CJobAction> OnLeaveAction { get; set;}

		[RED("onFastLeaveAction")] 		public CPtr<CJobForceOutAction> OnFastLeaveAction { get; set;}

		[RED("childNodes", 2,0)] 		public CArray<CPtr<CJobTreeNode>> ChildNodes { get; set;}

		[RED("validCategories", 2,0)] 		public CArray<CName> ValidCategories { get; set;}

		[RED("selectionMode")] 		public CEnum<EJobTreeNodeSelectionMode> SelectionMode { get; set;}

		[RED("iterations")] 		public CUInt32 Iterations { get; set;}

		[RED("leftItem")] 		public CName LeftItem { get; set;}

		[RED("rightItem")] 		public CName RightItem { get; set;}

		[RED("looped")] 		public CBool Looped { get; set;}

		public CJobTreeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CJobTreeNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}