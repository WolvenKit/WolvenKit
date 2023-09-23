using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftItemForTarget : ActionBool
	{
		[Ordinal(38)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public CraftItemForTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
