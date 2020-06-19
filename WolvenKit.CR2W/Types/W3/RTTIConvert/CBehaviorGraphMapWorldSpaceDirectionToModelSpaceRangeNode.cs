using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMapWorldSpaceDirectionToModelSpaceRangeNode : CBehaviorGraphValueBaseNode
	{
		[RED("minOutValue")] 		public CFloat MinOutValue { get; set;}

		[RED("maxOutValue")] 		public CFloat MaxOutValue { get; set;}

		[RED("leftToRight")] 		public CBool LeftToRight { get; set;}

		public CBehaviorGraphMapWorldSpaceDirectionToModelSpaceRangeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphMapWorldSpaceDirectionToModelSpaceRangeNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}