using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WeakspotOnDestroyProperties : CVariable
	{
		[Ordinal(0)] [RED("isInternal")] public CBool IsInternal { get; set; }
		[Ordinal(1)] [RED("disableInteraction")] public CBool DisableInteraction { get; set; }
		[Ordinal(2)] [RED("destroyMesh")] public CBool DestroyMesh { get; set; }
		[Ordinal(3)] [RED("disableCollider")] public CBool DisableCollider { get; set; }
		[Ordinal(4)] [RED("hideMeshParameterValue")] public CName HideMeshParameterValue { get; set; }
		[Ordinal(5)] [RED("playHitFxFromOwnerEntity")] public CBool PlayHitFxFromOwnerEntity { get; set; }
		[Ordinal(6)] [RED("playDestroyedFxFromOwnerEntity")] public CBool PlayDestroyedFxFromOwnerEntity { get; set; }
		[Ordinal(7)] [RED("playBrokenFxFromOwnerEntity")] public CBool PlayBrokenFxFromOwnerEntity { get; set; }
		[Ordinal(8)] [RED("addFact")] public CName AddFact { get; set; }
		[Ordinal(9)] [RED("sendAIActionAnimFeatureName")] public CName SendAIActionAnimFeatureName { get; set; }
		[Ordinal(10)] [RED("sendAIActionAnimFeatureState")] public CInt32 SendAIActionAnimFeatureState { get; set; }
		[Ordinal(11)] [RED("destroyDelay")] public CFloat DestroyDelay { get; set; }
		[Ordinal(12)] [RED("attackRecordID")] public TweakDBID AttackRecordID { get; set; }
		[Ordinal(13)] [RED("StatusEffectOnDestroyID")] public TweakDBID StatusEffectOnDestroyID { get; set; }

		public WeakspotOnDestroyProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
