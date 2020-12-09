using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicsConverterNode : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("cachedAnimInputNode")] 		public CPtr<CBehaviorGraphNode> CachedAnimInputNode { get; set;}

		[Ordinal(2)] [RED("cachedMimicBaseInputNode")] 		public CPtr<CBehaviorGraphNode> CachedMimicBaseInputNode { get; set;}

		[Ordinal(3)] [RED("placerPrefix")] 		public CString PlacerPrefix { get; set;}

		[Ordinal(4)] [RED("normalBlendTracksBegin")] 		public CInt32 NormalBlendTracksBegin { get; set;}

		[Ordinal(5)] [RED("mimicLipsyncOffset")] 		public CInt32 MimicLipsyncOffset { get; set;}

		[Ordinal(6)] [RED("mimicsConstraints", 2,0)] 		public CArray<CPtr<IBehaviorMimicConstraint>> MimicsConstraints { get; set;}

		public CBehaviorGraphMimicsConverterNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphMimicsConverterNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}