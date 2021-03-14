using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsMappinComponent : entIPlacedComponent
	{
		private gamemappinsMappinData _data;

		[Ordinal(5)] 
		[RED("data")] 
		public gamemappinsMappinData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (gamemappinsMappinData) CR2WTypeManager.Create("gamemappinsMappinData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public gamemappinsMappinComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
