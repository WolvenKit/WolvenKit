using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphComboStateNode : CBehaviorGraphStateNode
	{
		[Ordinal(1)] [RED("isConnected")] 		public CBool IsConnected { get; set;}

		[Ordinal(2)] [RED("comboWays", 2,0)] 		public CArray<SBehaviorComboWay> ComboWays { get; set;}

		[Ordinal(3)] [RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[Ordinal(4)] [RED("blendForAnim")] 		public CFloat BlendForAnim { get; set;}

		[Ordinal(5)] [RED("blendInternal")] 		public CFloat BlendInternal { get; set;}

		[Ordinal(6)] [RED("maxLevel")] 		public CUInt32 MaxLevel { get; set;}

		[Ordinal(7)] [RED("comboEvent")] 		public CName ComboEvent { get; set;}

		[Ordinal(8)] [RED("finishedEvent")] 		public CName FinishedEvent { get; set;}

		[Ordinal(9)] [RED("varComboWay")] 		public CName VarComboWay { get; set;}

		[Ordinal(10)] [RED("varComboDist")] 		public CName VarComboDist { get; set;}

		[Ordinal(11)] [RED("varComboDir")] 		public CName VarComboDir { get; set;}

		[Ordinal(12)] [RED("slotA")] 		public CPtr<CBehaviorGraphAnimationNode> SlotA { get; set;}

		[Ordinal(13)] [RED("slotB")] 		public CPtr<CBehaviorGraphAnimationNode> SlotB { get; set;}

		public CBehaviorGraphComboStateNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphComboStateNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}