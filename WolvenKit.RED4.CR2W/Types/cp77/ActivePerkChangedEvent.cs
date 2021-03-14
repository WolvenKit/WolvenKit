using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivePerkChangedEvent : redEvent
	{
		private CEnum<gamedataPerkArea> _perkArea;
		private CEnum<gamedataPerkType> _perkType;

		[Ordinal(0)] 
		[RED("perkArea")] 
		public CEnum<gamedataPerkArea> PerkArea
		{
			get
			{
				if (_perkArea == null)
				{
					_perkArea = (CEnum<gamedataPerkArea>) CR2WTypeManager.Create("gamedataPerkArea", "perkArea", cr2w, this);
				}
				return _perkArea;
			}
			set
			{
				if (_perkArea == value)
				{
					return;
				}
				_perkArea = value;
				PropertySet(this);
			}
		}

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

		public ActivePerkChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
