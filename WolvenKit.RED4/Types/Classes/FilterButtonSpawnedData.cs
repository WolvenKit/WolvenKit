using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FilterButtonSpawnedData : IScriptable
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CInt32 Type
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public FilterButtonSpawnedData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
