using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChangeAppearanceEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("resetAppearance")] 
		public CBool ResetAppearance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("previousAppearance")] 
		public CName PreviousAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public ChangeAppearanceEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
