using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entComponentsStorage : ISerializable
	{
		[Ordinal(0)] 
		[RED("components")] 
		public CArray<CHandle<entIComponent>> Components
		{
			get => GetPropertyValue<CArray<CHandle<entIComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIComponent>>>(value);
		}

		public entComponentsStorage()
		{
			Components = new();
		}
	}
}
