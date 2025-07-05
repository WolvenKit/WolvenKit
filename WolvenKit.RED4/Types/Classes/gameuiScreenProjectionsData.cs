using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiScreenProjectionsData : IScriptable
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CArray<CHandle<inkScreenProjection>> Data
		{
			get => GetPropertyValue<CArray<CHandle<inkScreenProjection>>>();
			set => SetPropertyValue<CArray<CHandle<inkScreenProjection>>>(value);
		}

		public gameuiScreenProjectionsData()
		{
			Data = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
