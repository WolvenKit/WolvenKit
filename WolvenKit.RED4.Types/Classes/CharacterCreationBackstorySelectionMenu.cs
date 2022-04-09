using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CharacterCreationBackstorySelectionMenu : gameuiBaseCharacterCreationController
	{
		[Ordinal(6)] 
		[RED("nomad")] 
		public inkWidgetReference Nomad
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("streetRat")] 
		public inkWidgetReference StreetRat
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("corpo")] 
		public inkWidgetReference Corpo
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(10)] 
		[RED("clickTarget")] 
		public CString ClickTarget
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("nomadTarget")] 
		public CString NomadTarget
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(12)] 
		[RED("streetTarget")] 
		public CString StreetTarget
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(13)] 
		[RED("corpoTarget")] 
		public CString CorpoTarget
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public CharacterCreationBackstorySelectionMenu()
		{
			Nomad = new();
			StreetRat = new();
			Corpo = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
