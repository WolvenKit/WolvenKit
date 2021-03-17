using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMappinResource : CResource
	{
		private CArray<gameCookedMappinData> _cookedData;
		private CArray<gameCookedMultiMappinData> _cookedMultiData;
		private CArray<gameCookedGpsMappinData> _cookedGpsData;

		[Ordinal(1)] 
		[RED("cookedData")] 
		public CArray<gameCookedMappinData> CookedData
		{
			get => GetProperty(ref _cookedData);
			set => SetProperty(ref _cookedData, value);
		}

		[Ordinal(2)] 
		[RED("cookedMultiData")] 
		public CArray<gameCookedMultiMappinData> CookedMultiData
		{
			get => GetProperty(ref _cookedMultiData);
			set => SetProperty(ref _cookedMultiData, value);
		}

		[Ordinal(3)] 
		[RED("cookedGpsData")] 
		public CArray<gameCookedGpsMappinData> CookedGpsData
		{
			get => GetProperty(ref _cookedGpsData);
			set => SetProperty(ref _cookedGpsData, value);
		}

		public gameMappinResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
