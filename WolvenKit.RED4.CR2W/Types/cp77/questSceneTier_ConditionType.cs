using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSceneTier_ConditionType : questISceneConditionType
	{
		private CEnum<GameplayTier> _tier;
		private CBool _isInverted;

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
		[RED("isInverted")] 
		public CBool IsInverted
		{
			get
			{
				if (_isInverted == null)
				{
					_isInverted = (CBool) CR2WTypeManager.Create("Bool", "isInverted", cr2w, this);
				}
				return _isInverted;
			}
			set
			{
				if (_isInverted == value)
				{
					return;
				}
				_isInverted = value;
				PropertySet(this);
			}
		}

		public questSceneTier_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
