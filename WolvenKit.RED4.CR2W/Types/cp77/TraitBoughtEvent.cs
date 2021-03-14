using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TraitBoughtEvent : redEvent
	{
		private CEnum<gamedataTraitType> _traitType;

		[Ordinal(0)] 
		[RED("traitType")] 
		public CEnum<gamedataTraitType> TraitType
		{
			get
			{
				if (_traitType == null)
				{
					_traitType = (CEnum<gamedataTraitType>) CR2WTypeManager.Create("gamedataTraitType", "traitType", cr2w, this);
				}
				return _traitType;
			}
			set
			{
				if (_traitType == value)
				{
					return;
				}
				_traitType = value;
				PropertySet(this);
			}
		}

		public TraitBoughtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
