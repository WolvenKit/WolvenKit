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
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(1)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(2)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(3)] 
		[RED("itemTag")] 
		public CName ItemTag
		{
			get => GetProperty(ref _itemTag);
			set => SetProperty(ref _itemTag, value);
		}

		[Ordinal(4)] 
		[RED("excludedTweakDBIDs")] 
		public CArray<TweakDBID> ExcludedTweakDBIDs
		{
			get => GetProperty(ref _excludedTweakDBIDs);
			set => SetProperty(ref _excludedTweakDBIDs, value);
		}

		[Ordinal(5)] 
		[RED("excludedTags")] 
		public CArray<CName> ExcludedTags
		{
			get => GetProperty(ref _excludedTags);
			set => SetProperty(ref _excludedTags, value);
		}

		[Ordinal(6)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		public questCharacterEquippedItem_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
