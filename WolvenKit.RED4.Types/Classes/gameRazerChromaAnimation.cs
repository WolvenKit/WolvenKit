using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameRazerChromaAnimation : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("buffer")] 
		public DataBuffer Buffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public gameRazerChromaAnimation()
		{
			Id = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
