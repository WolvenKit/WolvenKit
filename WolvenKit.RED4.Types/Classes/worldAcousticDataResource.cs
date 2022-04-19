using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAcousticDataResource : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("cells")] 
		public CArray<worldAcousticDataCell> Cells
		{
			get => GetPropertyValue<CArray<worldAcousticDataCell>>();
			set => SetPropertyValue<CArray<worldAcousticDataCell>>(value);
		}

		public worldAcousticDataResource()
		{
			Cells = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
