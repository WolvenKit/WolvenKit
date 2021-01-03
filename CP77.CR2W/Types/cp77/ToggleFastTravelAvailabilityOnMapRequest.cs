using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ToggleFastTravelAvailabilityOnMapRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(1)]  [RED("pointRecord")] public TweakDBID PointRecord { get; set; }

		public ToggleFastTravelAvailabilityOnMapRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
