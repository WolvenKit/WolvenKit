using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_VehiclePassengerAnimSetup : animAnimFeature
	{
		[Ordinal(0)]  [RED("additiveScale")] public CFloat AdditiveScale { get; set; }
		[Ordinal(1)]  [RED("enableAdditiveAnim")] public CBool EnableAdditiveAnim { get; set; }

		public animAnimFeature_VehiclePassengerAnimSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
