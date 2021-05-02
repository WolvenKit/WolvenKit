using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJobTreeNode : CObject
	{
		[Ordinal(1)] [RED("onEnterAction")] 		public CPtr<CJobAction> OnEnterAction { get; set;}

		[Ordinal(2)] [RED("onLeaveAction")] 		public CPtr<CJobAction> OnLeaveAction { get; set;}

		[Ordinal(3)] [RED("onFastLeaveAction")] 		public CPtr<CJobForceOutAction> OnFastLeaveAction { get; set;}

		[Ordinal(4)] [RED("childNodes", 2,0)] 		public CArray<CPtr<CJobTreeNode>> ChildNodes { get; set;}

		[Ordinal(5)] [RED("validCategories", 2,0)] 		public CArray<CName> ValidCategories { get; set;}

		[Ordinal(6)] [RED("selectionMode")] 		public CEnum<EJobTreeNodeSelectionMode> SelectionMode { get; set;}

		[Ordinal(7)] [RED("iterations")] 		public CUInt32 Iterations { get; set;}

		[Ordinal(8)] [RED("leftItem")] 		public CName LeftItem { get; set;}

		[Ordinal(9)] [RED("rightItem")] 		public CName RightItem { get; set;}

		[Ordinal(10)] [RED("looped")] 		public CBool Looped { get; set;}

		public CJobTreeNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CJobTreeNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}