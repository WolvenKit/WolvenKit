using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendFont : CResource
	{
		[Ordinal(1)] 
		[RED("fontBuffer")] 
		public DataBuffer FontBuffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public rendFont()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
