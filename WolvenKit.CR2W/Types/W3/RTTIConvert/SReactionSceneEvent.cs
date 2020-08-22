using System.IO;
using System.Runtime.Serialization;
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

		public SReactionSceneEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SReactionSceneEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}