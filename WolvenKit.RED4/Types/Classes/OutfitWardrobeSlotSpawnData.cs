using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OutfitWardrobeSlotSpawnData : IScriptable
	{
		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("equipped")] 
		public CBool Equipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isNew")] 
		public CBool IsNew
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public OutfitWardrobeSlotSpawnData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
