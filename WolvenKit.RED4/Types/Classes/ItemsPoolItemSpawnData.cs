using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemsPoolItemSpawnData : IScriptable
	{
		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("requestVersion")] 
		public CInt32 RequestVersion
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ItemsPoolItemSpawnData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
