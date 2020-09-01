using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphSynchronizeAnimationsToParentNode : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("Synchronize to input")] 		public CBool Synchronize_to_input { get; set;}

		[Ordinal(2)] [RED("Auto use anims with same name")] 		public CBool Auto_use_anims_with_same_name { get; set;}

		[Ordinal(3)] [RED("Animation stay multiplier")] 		public CFloat Animation_stay_multiplier { get; set;}

		[Ordinal(4)] [RED("Sync to normal/full body anims")] 		public CBool Sync_to_normal_full_body_anims { get; set;}

		[Ordinal(5)] [RED("Sync to overlay body anims")] 		public CBool Sync_to_overlay_body_anims { get; set;}

		[Ordinal(6)] [RED("Skip normal/full body anims when syncing overlay anims")] 		public CBool Skip_normal_full_body_anims_when_syncing_overlay_anims { get; set;}

		[Ordinal(7)] [RED("Sync default to any looped anim found")] 		public CBool Sync_default_to_any_looped_anim_found { get; set;}

		[Ordinal(8)] [RED("Default")] 		public SSynchronizeAnimationToParentDefinition Default { get; set;}

		[Ordinal(9)] [RED("Anims", 2,0)] 		public CArray<SSynchronizeAnimationToParentDefinition> Anims { get; set;}

		[Ordinal(10)] [RED("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		public CBehaviorGraphSynchronizeAnimationsToParentNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphSynchronizeAnimationsToParentNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}