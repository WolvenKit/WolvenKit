using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldLocationAreaNode : worldTriggerAreaNode
	{
		[Ordinal(5)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public worldLocationAreaNode()
		{
			Color = new CColor { Green = 255, Blue = 255, Alpha = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
