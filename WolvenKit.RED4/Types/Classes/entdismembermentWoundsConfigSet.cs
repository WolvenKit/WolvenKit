using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentWoundsConfigSet : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Configs")] 
		public CArray<CHandle<entdismembermentWoundConfigContainer>> Configs
		{
			get => GetPropertyValue<CArray<CHandle<entdismembermentWoundConfigContainer>>>();
			set => SetPropertyValue<CArray<CHandle<entdismembermentWoundConfigContainer>>>(value);
		}

		public entdismembermentWoundsConfigSet()
		{
			Configs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
