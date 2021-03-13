using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EnableFastTravelRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(1)] [RED("forceRefreshUI")] public CBool ForceRefreshUI { get; set; }
		[Ordinal(2)] [RED("reason")] public CName Reason { get; set; }
		[Ordinal(3)] [RED("linkedStatusEffectID")] public TweakDBID LinkedStatusEffectID { get; set; }

		public EnableFastTravelRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
