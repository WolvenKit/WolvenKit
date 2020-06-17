using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicsConverterNode : CBehaviorGraphNode
	{
		[RED("cachedAnimInputNode")] 		public CPtr<CBehaviorGraphNode> CachedAnimInputNode { get; set;}

		[RED("cachedMimicBaseInputNode")] 		public CPtr<CBehaviorGraphNode> CachedMimicBaseInputNode { get; set;}

		[RED("placerPrefix")] 		public CString PlacerPrefix { get; set;}

		[RED("normalBlendTracksBegin")] 		public CInt32 NormalBlendTracksBegin { get; set;}

		[RED("mimicLipsyncOffset")] 		public CInt32 MimicLipsyncOffset { get; set;}

		[RED("mimicsConstraints", 2,0)] 		public CArray<CPtr<IBehaviorMimicConstraint>> MimicsConstraints { get; set;}

		public CBehaviorGraphMimicsConverterNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphMimicsConverterNode(cr2w);

	}
}