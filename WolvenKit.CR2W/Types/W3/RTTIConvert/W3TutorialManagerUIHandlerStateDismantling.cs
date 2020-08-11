using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateDismantling : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("DESCRIPTION")] 		public CName DESCRIPTION { get; set;}

		[RED("ITEMS")] 		public CName ITEMS { get; set;}

		[RED("COMPONENTS")] 		public CName COMPONENTS { get; set;}

		[RED("COST")] 		public CName COST { get; set;}

		[RED("DISMANTLING")] 		public CName DISMANTLING { get; set;}

		[RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateDismantling(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateDismantling(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}