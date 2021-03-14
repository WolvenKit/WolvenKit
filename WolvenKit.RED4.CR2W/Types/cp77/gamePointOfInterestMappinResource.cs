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
			get
			{
				if (_cookedData == null)
				{
					_cookedData = (CArray<gameCookedPointOfInterestMappinData>) CR2WTypeManager.Create("array:gameCookedPointOfInterestMappinData", "cookedData", cr2w, this);
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

		public gamePointOfInterestMappinResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
