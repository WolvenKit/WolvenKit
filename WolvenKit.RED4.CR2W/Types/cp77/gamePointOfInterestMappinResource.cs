using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePointOfInterestMappinResource : CResource
	{
		[Ordinal(1)] [RED("cookedData")] public CArray<gameCookedPointOfInterestMappinData> CookedData { get; set; }

		public gamePointOfInterestMappinResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
