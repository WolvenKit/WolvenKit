using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IncreaseTraitLevel : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataTraitType> _trait;

		[Ordinal(1)] 
		[RED("trait")] 
		public CEnum<gamedataTraitType> Trait
		{
			get
			{
				if (_trait == null)
				{
					_trait = (CEnum<gamedataTraitType>) CR2WTypeManager.Create("gamedataTraitType", "trait", cr2w, this);
				}
				return _trait;
			}
			set
			{
				if (_trait == value)
				{
					return;
				}
				_trait = value;
				PropertySet(this);
			}
		}

		public IncreaseTraitLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
