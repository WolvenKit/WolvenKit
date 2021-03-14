using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTierPrereq : gameIComparisonPrereq
	{
		private CEnum<GameplayTier> _tier;

		[Ordinal(1)] 
		[RED("tier")] 
		public CEnum<GameplayTier> Tier
		{
			get
			{
				if (_tier == null)
				{
					_tier = (CEnum<GameplayTier>) CR2WTypeManager.Create("GameplayTier", "tier", cr2w, this);
				}
				return _tier;
			}
			set
			{
				if (_tier == value)
				{
					return;
				}
				_tier = value;
				PropertySet(this);
			}
		}

		public gameTierPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
