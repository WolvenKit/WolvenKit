using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootObject : gameObject
	{
		private TweakDBID _lootID;
		private CBool _isInIconForcedVisibilityRange;
		private CName _activeQualityRangeInteraction;

		[Ordinal(40)] 
		[RED("lootID")] 
		public TweakDBID LootID
		{
			get
			{
				if (_lootID == null)
				{
					_lootID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "lootID", cr2w, this);
				}
				return _lootID;
			}
			set
			{
				if (_lootID == value)
				{
					return;
				}
				_lootID = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("isInIconForcedVisibilityRange")] 
		public CBool IsInIconForcedVisibilityRange
		{
			get
			{
				if (_isInIconForcedVisibilityRange == null)
				{
					_isInIconForcedVisibilityRange = (CBool) CR2WTypeManager.Create("Bool", "isInIconForcedVisibilityRange", cr2w, this);
				}
				return _isInIconForcedVisibilityRange;
			}
			set
			{
				if (_isInIconForcedVisibilityRange == value)
				{
					return;
				}
				_isInIconForcedVisibilityRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("activeQualityRangeInteraction")] 
		public CName ActiveQualityRangeInteraction
		{
			get
			{
				if (_activeQualityRangeInteraction == null)
				{
					_activeQualityRangeInteraction = (CName) CR2WTypeManager.Create("CName", "activeQualityRangeInteraction", cr2w, this);
				}
				return _activeQualityRangeInteraction;
			}
			set
			{
				if (_activeQualityRangeInteraction == value)
				{
					return;
				}
				_activeQualityRangeInteraction = value;
				PropertySet(this);
			}
		}

		public gameLootObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
