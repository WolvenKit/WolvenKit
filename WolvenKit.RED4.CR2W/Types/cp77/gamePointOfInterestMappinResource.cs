using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePointOfInterestMappinResource : CResource
	{
		private CArray<gameCookedPointOfInterestMappinData> _cookedData;

		[Ordinal(1)] 
		[RED("cookedData")] 
		public CArray<gameCookedPointOfInterestMappinData> CookedData
		{
			get => GetProperty(ref _cookedData);
			set => SetProperty(ref _cookedData, value);
		}

		public gamePointOfInterestMappinResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
