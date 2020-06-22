using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskKill : IBehTreeTask
	{
		[RED("actor")] 		public CHandle<CActor> Actor { get; set;}

		[RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[RED("fact")] 		public CString Fact { get; set;}

		[RED("value")] 		public CInt32 Value { get; set;}

		[RED("validFor")] 		public CInt32 ValidFor { get; set;}

		[RED("signalGameplayEvent")] 		public CName SignalGameplayEvent { get; set;}

		[RED("playEffectOnKill")] 		public CName PlayEffectOnKill { get; set;}

		[RED("self")] 		public CBool Self { get; set;}

		[RED("target")] 		public CBool Target { get; set;}

		[RED("player")] 		public CBool Player { get; set;}

		[RED("onlyBelowHealthPercent")] 		public CFloat OnlyBelowHealthPercent { get; set;}

		[RED("onDamageTaken")] 		public CBool OnDamageTaken { get; set;}

		[RED("onAardHit")] 		public CBool OnAardHit { get; set;}

		[RED("onIgniHit")] 		public CBool OnIgniHit { get; set;}

		[RED("onAxiiHit")] 		public CBool OnAxiiHit { get; set;}

		[RED("onHeadshot")] 		public CBool OnHeadshot { get; set;}

		[RED("onCustomHit")] 		public CBool OnCustomHit { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("onListenToGameplayEvents")] 		public CBool OnListenToGameplayEvents { get; set;}

		[RED("setBehVarOnKill")] 		public CName SetBehVarOnKill { get; set;}

		[RED("behVarValue")] 		public CFloat BehVarValue { get; set;}

		public CBTTaskKill(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskKill(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}