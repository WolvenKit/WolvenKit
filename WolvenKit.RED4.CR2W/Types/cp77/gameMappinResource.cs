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
			get
			{
				if (_cookedData == null)
				{
					_cookedData = (CArray<gameCookedMappinData>) CR2WTypeManager.Create("array:gameCookedMappinData", "cookedData", cr2w, this);
				}
				return _cookedData;
			}
			set
			{
				if (_cookedData == value)
				{
					return;
				}
				_cookedData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cookedMultiData")] 
		public CArray<gameCookedMultiMappinData> CookedMultiData
		{
			get
			{
				if (_cookedMultiData == null)
				{
					_cookedMultiData = (CArray<gameCookedMultiMappinData>) CR2WTypeManager.Create("array:gameCookedMultiMappinData", "cookedMultiData", cr2w, this);
				}
				return _cookedMultiData;
			}
			set
			{
				if (_cookedMultiData == value)
				{
					return;
				}
				_cookedMultiData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cookedGpsData")] 
		public CArray<gameCookedGpsMappinData> CookedGpsData
		{
			get
			{
				if (_cookedGpsData == null)
				{
					_cookedGpsData = (CArray<gameCookedGpsMappinData>) CR2WTypeManager.Create("array:gameCookedGpsMappinData", "cookedGpsData", cr2w, this);
				}
				return _cookedGpsData;
			}
			set
			{
				if (_cookedGpsData == value)
				{
					return;
				}
				_cookedGpsData = value;
				PropertySet(this);
			}
		}

		public gameMappinResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
