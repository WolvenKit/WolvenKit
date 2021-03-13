using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeDecoratorSnapToNavigationDefinition : IBehTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] [RED("performActivation")] 		public CBool PerformActivation { get; set;}

		[Ordinal(2)] [RED("snapOnActivation")] 		public CBool SnapOnActivation { get; set;}

		[Ordinal(3)] [RED("performDeactivation")] 		public CBool PerformDeactivation { get; set;}

		[Ordinal(4)] [RED("snapOnDeactivation")] 		public CBool SnapOnDeactivation { get; set;}

		public CBehTreeNodeDecoratorSnapToNavigationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeDecoratorSnapToNavigationDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}