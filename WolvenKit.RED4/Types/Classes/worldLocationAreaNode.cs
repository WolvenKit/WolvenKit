using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldLocationAreaNode : worldTriggerAreaNode
	{
		[Ordinal(7)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public worldLocationAreaNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
