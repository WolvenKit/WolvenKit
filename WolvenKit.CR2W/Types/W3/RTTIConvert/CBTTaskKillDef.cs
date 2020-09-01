using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskKillDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("fact")] 		public CString Fact { get; set;}

		[Ordinal(2)] [RED("value")] 		public CInt32 Value { get; set;}

		[Ordinal(3)] [RED("validFor")] 		public CInt32 ValidFor { get; set;}

		[Ordinal(4)] [RED("signalGameplayEvent")] 		public CName SignalGameplayEvent { get; set;}

		[Ordinal(5)] [RED("playEffectOnKill")] 		public CName PlayEffectOnKill { get; set;}

		[Ordinal(6)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(7)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(8)] [RED("target")] 		public CBool Target { get; set;}

		[Ordinal(9)] [RED("player")] 		public CBool Player { get; set;}

		[Ordinal(10)] [RED("self")] 		public CBool Self { get; set;}

		[Ordinal(11)] [RED("onlyBelowHealthPercent")] 		public CFloat OnlyBelowHealthPercent { get; set;}

		[Ordinal(12)] [RED("onAardHit")] 		public CBool OnAardHit { get; set;}

		[Ordinal(13)] [RED("onIgniHit")] 		public CBool OnIgniHit { get; set;}

		[Ordinal(14)] [RED("onAxiiHit")] 		public CBool OnAxiiHit { get; set;}

		[Ordinal(15)] [RED("onCustomHit")] 		public CBool OnCustomHit { get; set;}

		[Ordinal(16)] [RED("onHeadshot")] 		public CBool OnHeadshot { get; set;}

		[Ordinal(17)] [RED("onDamageTaken")] 		public CBool OnDamageTaken { get; set;}

		[Ordinal(18)] [RED("onListenToGameplayEvents")] 		public CBool OnListenToGameplayEvents { get; set;}

		[Ordinal(19)] [RED("setBehVarOnKill")] 		public CName SetBehVarOnKill { get; set;}

		[Ordinal(20)] [RED("behVarValue")] 		public CFloat BehVarValue { get; set;}

		public CBTTaskKillDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskKillDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}