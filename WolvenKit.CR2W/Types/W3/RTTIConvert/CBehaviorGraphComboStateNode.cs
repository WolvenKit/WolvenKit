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
		[Ordinal(0)] [RED("("isConnected")] 		public CBool IsConnected { get; set;}

		[Ordinal(0)] [RED("("comboWays", 2,0)] 		public CArray<SBehaviorComboWay> ComboWays { get; set;}

		[Ordinal(0)] [RED("("cooldown")] 		public CFloat Cooldown { get; set;}

		[Ordinal(0)] [RED("("blendForAnim")] 		public CFloat BlendForAnim { get; set;}

		[Ordinal(0)] [RED("("blendInternal")] 		public CFloat BlendInternal { get; set;}

		[Ordinal(0)] [RED("("maxLevel")] 		public CUInt32 MaxLevel { get; set;}

		[Ordinal(0)] [RED("("comboEvent")] 		public CName ComboEvent { get; set;}

		[Ordinal(0)] [RED("("finishedEvent")] 		public CName FinishedEvent { get; set;}

		[Ordinal(0)] [RED("("varComboWay")] 		public CName VarComboWay { get; set;}

		[Ordinal(0)] [RED("("varComboDist")] 		public CName VarComboDist { get; set;}

		[Ordinal(0)] [RED("("varComboDir")] 		public CName VarComboDir { get; set;}

		[Ordinal(0)] [RED("("slotA")] 		public CPtr<CBehaviorGraphAnimationNode> SlotA { get; set;}

		[Ordinal(0)] [RED("("slotB")] 		public CPtr<CBehaviorGraphAnimationNode> SlotB { get; set;}

		public CBehaviorGraphComboStateNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphComboStateNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}