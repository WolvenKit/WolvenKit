using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventMimicsAnim : CStorySceneEventAnimClip
	{
		[Ordinal(0)] [RED("animationName")] public CName AnimationName { get; set; }

		[Ordinal(1)] [RED("fullEyesWeight")] public CBool FullEyesWeight { get; set; }

		[Ordinal(2)] [RED("filterOption")] public CName FilterOption { get; set; }

		[Ordinal(3)] [RED("friendlyName")] public CString FriendlyName { get; set; }



		public CStorySceneEventMimicsAnim(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}