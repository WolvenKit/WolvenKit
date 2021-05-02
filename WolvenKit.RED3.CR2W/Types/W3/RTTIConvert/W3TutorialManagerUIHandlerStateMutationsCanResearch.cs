using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateMutationsCanResearch : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("SELECT_ADVANCED")] 		public CName SELECT_ADVANCED { get; set;}

		[Ordinal(2)] [RED("PREREQUISITES")] 		public CName PREREQUISITES { get; set;}

		[Ordinal(3)] [RED("RESEARCHING")] 		public CName RESEARCHING { get; set;}

		[Ordinal(4)] [RED("SELECT")] 		public CName SELECT { get; set;}

		[Ordinal(5)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		[Ordinal(6)] [RED("selectedMutation")] 		public CEnum<EPlayerMutationType> SelectedMutation { get; set;}

		public W3TutorialManagerUIHandlerStateMutationsCanResearch(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateMutationsCanResearch(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}