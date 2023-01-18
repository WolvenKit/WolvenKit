using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkPropertyManager : ISerializable
	{
		[Ordinal(0)] 
		[RED("bindings")] 
		public CArray<inkPropertyBinding> Bindings
		{
			get => GetPropertyValue<CArray<inkPropertyBinding>>();
			set => SetPropertyValue<CArray<inkPropertyBinding>>(value);
		}

		public inkPropertyManager()
		{
			Bindings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
