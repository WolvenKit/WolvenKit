using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphSynchronizeAnimationsToParentNode : CBehaviorGraphNode
	{
		[RED("Synchronize to input")] 		public CBool Synchronize_to_input { get; set;}

		[RED("Auto use anims with same name")] 		public CBool Auto_use_anims_with_same_name { get; set;}

		[RED("Animation stay multiplier")] 		public CFloat Animation_stay_multiplier { get; set;}

		[RED("Sync to normal/full body anims")] 		public CBool Sync_to_normal_full_body_anims { get; set;}

		[RED("Sync to overlay body anims")] 		public CBool Sync_to_overlay_body_anims { get; set;}

		[RED("Skip normal/full body anims when syncing overlay anims")] 		public CBool Skip_normal_full_body_anims_when_syncing_overlay_anims { get; set;}

		[RED("Sync default to any looped anim found")] 		public CBool Sync_default_to_any_looped_anim_found { get; set;}

		[RED("Default")] 		public SSynchronizeAnimationToParentDefinition Default { get; set;}

		[RED("Anims", 2,0)] 		public CArray<SSynchronizeAnimationToParentDefinition> Anims { get; set;}

		[RED("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		public CBehaviorGraphSynchronizeAnimationsToParentNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphSynchronizeAnimationsToParentNode(cr2w);

	}
}