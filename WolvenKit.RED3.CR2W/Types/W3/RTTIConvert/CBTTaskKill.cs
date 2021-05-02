using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskKill : IBehTreeTask
	{
		[Ordinal(1)] [RED("actor")] 		public CHandle<CActor> Actor { get; set;}

		[Ordinal(2)] [RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[Ordinal(3)] [RED("fact")] 		public CString Fact { get; set;}

		[Ordinal(4)] [RED("value")] 		public CInt32 Value { get; set;}

		[Ordinal(5)] [RED("validFor")] 		public CInt32 ValidFor { get; set;}

		[Ordinal(6)] [RED("signalGameplayEvent")] 		public CName SignalGameplayEvent { get; set;}

		[Ordinal(7)] [RED("playEffectOnKill")] 		public CName PlayEffectOnKill { get; set;}

		[Ordinal(8)] [RED("self")] 		public CBool Self { get; set;}

		[Ordinal(9)] [RED("target")] 		public CBool Target { get; set;}

		[Ordinal(10)] [RED("player")] 		public CBool Player { get; set;}

		[Ordinal(11)] [RED("onlyBelowHealthPercent")] 		public CFloat OnlyBelowHealthPercent { get; set;}

		[Ordinal(12)] [RED("onDamageTaken")] 		public CBool OnDamageTaken { get; set;}

		[Ordinal(13)] [RED("onAardHit")] 		public CBool OnAardHit { get; set;}

		[Ordinal(14)] [RED("onIgniHit")] 		public CBool OnIgniHit { get; set;}

		[Ordinal(15)] [RED("onAxiiHit")] 		public CBool OnAxiiHit { get; set;}

		[Ordinal(16)] [RED("onHeadshot")] 		public CBool OnHeadshot { get; set;}

		[Ordinal(17)] [RED("onCustomHit")] 		public CBool OnCustomHit { get; set;}

		[Ordinal(18)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(19)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(20)] [RED("onListenToGameplayEvents")] 		public CBool OnListenToGameplayEvents { get; set;}

		[Ordinal(21)] [RED("setBehVarOnKill")] 		public CName SetBehVarOnKill { get; set;}

		[Ordinal(22)] [RED("behVarValue")] 		public CFloat BehVarValue { get; set;}

		public CBTTaskKill(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskKill(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}