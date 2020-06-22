using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeSelectTargetByTagInAreaDecoratorDefinition : CBehTreeNodeSelectTargetByTagDecoratorDefinition
	{
		[RED("areaSelection")] 		public SBehTreeAreaSelection AreaSelection { get; set;}

		[RED("getClosest")] 		public CBehTreeValBool GetClosest { get; set;}

		[RED("reselectOnActivate")] 		public CBehTreeValBool ReselectOnActivate { get; set;}

		public CBehTreeNodeSelectTargetByTagInAreaDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeSelectTargetByTagInAreaDecoratorDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}