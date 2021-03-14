using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkPrereq : gameIScriptablePrereq
	{
		private CEnum<gamedataPerkType> _perk;

		[Ordinal(0)] 
		[RED("perk")] 
		public CEnum<gamedataPerkType> Perk
		{
			get
			{
				if (_perk == null)
				{
					_perk = (CEnum<gamedataPerkType>) CR2WTypeManager.Create("gamedataPerkType", "perk", cr2w, this);
				}
				return _perk;
			}
			set
			{
				if (_perk == value)
				{
					return;
				}
				_perk = value;
				PropertySet(this);
			}
		}

		public PerkPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
