using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetUpEquipmentOverlayEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("meshOverlayEffectName")] 
		public CName MeshOverlayEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("meshOverlayEffectTag")] 
		public CName MeshOverlayEffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("meshOverlaySlots")] 
		public CArray<TweakDBID> MeshOverlaySlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		public SetUpEquipmentOverlayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
