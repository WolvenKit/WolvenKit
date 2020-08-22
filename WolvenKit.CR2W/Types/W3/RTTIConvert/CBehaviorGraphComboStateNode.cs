using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphComboStateNode : CBehaviorGraphStateNode
	{
		[RED("isConnected")] 		public CBool IsConnected { get; set;}

		[RED("comboWays", 2,0)] 		public CArray<SBehaviorComboWay> ComboWays { get; set;}

		[RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[RED("blendForAnim")] 		public CFloat BlendForAnim { get; set;}

		[RED("blendInternal")] 		public CFloat BlendInternal { get; set;}

		[RED("maxLevel")] 		public CUInt32 MaxLevel { get; set;}

		[RED("comboEvent")] 		public CName ComboEvent { get; set;}

		[RED("finishedEvent")] 		public CName FinishedEvent { get; set;}

		[RED("varComboWay")] 		public CName VarComboWay { get; set;}

		[RED("varComboDist")] 		public CName VarComboDist { get; set;}

		[RED("varComboDir")] 		public CName VarComboDir { get; set;}

		[RED("slotA")] 		public CPtr<CBehaviorGraphAnimationNode> SlotA { get; set;}

		[RED("slotB")] 		public CPtr<CBehaviorGraphAnimationNode> SlotB { get; set;}

		public CBehaviorGraphComboStateNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphComboStateNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}