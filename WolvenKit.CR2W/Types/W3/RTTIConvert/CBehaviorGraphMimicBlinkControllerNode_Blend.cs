using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicBlinkControllerNode_Blend : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("("trackEyeLeft_Down")] 		public CString TrackEyeLeft_Down { get; set;}

		[Ordinal(2)] [RED("("trackEyeRight_Down")] 		public CString TrackEyeRight_Down { get; set;}

		[Ordinal(3)] [RED("("blinkValueThr")] 		public CFloat BlinkValueThr { get; set;}

		[Ordinal(4)] [RED("("blinkCooldown")] 		public CFloat BlinkCooldown { get; set;}

		[Ordinal(5)] [RED("("cachedInputIdle")] 		public CPtr<CBehaviorGraphNode> CachedInputIdle { get; set;}

		[Ordinal(6)] [RED("("cachedInputRest")] 		public CPtr<CBehaviorGraphNode> CachedInputRest { get; set;}

		public CBehaviorGraphMimicBlinkControllerNode_Blend(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphMimicBlinkControllerNode_Blend(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}