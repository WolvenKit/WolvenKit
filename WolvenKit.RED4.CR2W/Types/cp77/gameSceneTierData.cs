using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSceneTierData : IScriptable
	{
		private CEnum<GameplayTier> _tier;
		private CBool _emptyHands;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("emptyHands")] 
		public CBool EmptyHands
		{
			get
			{
				if (_emptyHands == null)
				{
					_emptyHands = (CBool) CR2WTypeManager.Create("Bool", "emptyHands", cr2w, this);
				}
				return _emptyHands;
			}
			set
			{
				if (_emptyHands == value)
				{
					return;
				}
				_emptyHands = value;
				PropertySet(this);
			}
		}

		public gameSceneTierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
