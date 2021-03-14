using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterEquippedItem_ConditionType : questICharacterConditionType
	{
		private CBool _isPlayer;
		private gameEntityReference _puppetRef;
		private TweakDBID _itemID;
		private CName _itemTag;
		private CArray<TweakDBID> _excludedTweakDBIDs;
		private CArray<CName> _excludedTags;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get
			{
				if (_puppetRef == null)
				{
					_puppetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppetRef", cr2w, this);
				}
				return _puppetRef;
			}
			set
			{
				if (_puppetRef == value)
				{
					return;
				}
				_puppetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("itemTag")] 
		public CName ItemTag
		{
			get
			{
				if (_itemTag == null)
				{
					_itemTag = (CName) CR2WTypeManager.Create("CName", "itemTag", cr2w, this);
				}
				return _itemTag;
			}
			set
			{
				if (_itemTag == value)
				{
					return;
				}
				_itemTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("excludedTweakDBIDs")] 
		public CArray<TweakDBID> ExcludedTweakDBIDs
		{
			get
			{
				if (_excludedTweakDBIDs == null)
				{
					_excludedTweakDBIDs = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "excludedTweakDBIDs", cr2w, this);
				}
				return _excludedTweakDBIDs;
			}
			set
			{
				if (_excludedTweakDBIDs == value)
				{
					return;
				}
				_excludedTweakDBIDs = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("excludedTags")] 
		public CArray<CName> ExcludedTags
		{
			get
			{
				if (_excludedTags == null)
				{
					_excludedTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "excludedTags", cr2w, this);
				}
				return _excludedTags;
			}
			set
			{
				if (_excludedTags == value)
				{
					return;
				}
				_excludedTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get
			{
				if (_inverted == null)
				{
					_inverted = (CBool) CR2WTypeManager.Create("Bool", "inverted", cr2w, this);
				}
				return _inverted;
			}
			set
			{
				if (_inverted == value)
				{
					return;
				}
				_inverted = value;
				PropertySet(this);
			}
		}

		public questCharacterEquippedItem_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
