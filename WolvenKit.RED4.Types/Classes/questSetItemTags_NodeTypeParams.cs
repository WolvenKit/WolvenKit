using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetItemTags_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public CHandle<questUniversalRef> ObjectRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(1)] 
		[RED("itemId")] 
		public TweakDBID ItemId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("addTags")] 
		public CBool AddTags
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("tags")] 
		public CBitField<gameEItemDynamicTags> Tags
		{
			get => GetPropertyValue<CBitField<gameEItemDynamicTags>>();
			set => SetPropertyValue<CBitField<gameEItemDynamicTags>>(value);
		}

		public questSetItemTags_NodeTypeParams()
		{
			AddTags = true;
			Tags = Enums.gameEItemDynamicTags.Quest;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
