using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SReactionSceneEvent : CVariable
	{
		[RED("reactionScene")] 		public CName ReactionScene { get; set;}

		[RED("requiredSceneInputs", 2,0)] 		public CArray<CString> RequiredSceneInputs { get; set;}

		[RED("inputsAsymetric")] 		public CBool InputsAsymetric { get; set;}

		[RED("workOnlyBroadcast")] 		public CBool WorkOnlyBroadcast { get; set;}

		public SReactionSceneEvent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SReactionSceneEvent(cr2w);

	}
}