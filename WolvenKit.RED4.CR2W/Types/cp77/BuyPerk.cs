using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BuyPerk : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataPerkType> _perkType;

		[Ordinal(1)] 
		[RED("perkType")] 
		public CEnum<gamedataPerkType> PerkType
		{
			get
			{
				if (_perkType == null)
				{
					_perkType = (CEnum<gamedataPerkType>) CR2WTypeManager.Create("gamedataPerkType", "perkType", cr2w, this);
				}
				return _perkType;
			}
			set
			{
				if (_perkType == value)
				{
					return;
				}
				_perkType = value;
				PropertySet(this);
			}
		}

		public BuyPerk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
