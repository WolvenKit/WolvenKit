using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAreaResource : CResource
	{
		private CArray<gameCookedAreaData> _cookedData;

		[Ordinal(1)] 
		[RED("cookedData")] 
		public CArray<gameCookedAreaData> CookedData
		{
			get
			{
				if (_cookedData == null)
				{
					_cookedData = (CArray<gameCookedAreaData>) CR2WTypeManager.Create("array:gameCookedAreaData", "cookedData", cr2w, this);
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

		public gameAreaResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
