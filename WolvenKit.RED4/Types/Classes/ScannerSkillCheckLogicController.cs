using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerSkillCheckLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("ScannerSkillCheckItemName")] 
		public CName ScannerSkillCheckItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("SkillCheckObjects")] 
		public CArray<CWeakHandle<inkWidget>> SkillCheckObjects
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(3)] 
		[RED("Root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		public ScannerSkillCheckLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
