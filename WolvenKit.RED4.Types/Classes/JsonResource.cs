using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JsonResource : CResource
	{
		[Ordinal(1)] 
		[RED("root")] 
		public CHandle<ISerializable> Root
		{
			get => GetPropertyValue<CHandle<ISerializable>>();
			set => SetPropertyValue<CHandle<ISerializable>>(value);
		}

		public JsonResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
