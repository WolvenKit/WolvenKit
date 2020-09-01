using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeDecoratorSnapToNavigationDefinition : IBehTreeNodeDecoratorDefinition
	{
		[Ordinal(0)] [RED("performActivation")] 		public CBool PerformActivation { get; set;}

		[Ordinal(0)] [RED("snapOnActivation")] 		public CBool SnapOnActivation { get; set;}

		[Ordinal(0)] [RED("performDeactivation")] 		public CBool PerformDeactivation { get; set;}

		[Ordinal(0)] [RED("snapOnDeactivation")] 		public CBool SnapOnDeactivation { get; set;}

		public CBehTreeNodeDecoratorSnapToNavigationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeDecoratorSnapToNavigationDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}