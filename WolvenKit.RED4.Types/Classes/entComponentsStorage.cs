using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entComponentsStorage : ISerializable
	{
		private CArray<CHandle<entIComponent>> _components;

		[Ordinal(0)] 
		[RED("components")] 
		public CArray<CHandle<entIComponent>> Components
		{
			get => GetProperty(ref _components);
			set => SetProperty(ref _components, value);
		}
	}
}
