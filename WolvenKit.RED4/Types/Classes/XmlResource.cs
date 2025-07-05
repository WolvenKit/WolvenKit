using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class XmlResource : CResource
	{
		[Ordinal(1)] 
		[RED("data")] 
		public CString Data
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public XmlResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
