using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnLocalMarker : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("transformLS")] 
		public Transform TransformLS
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public scnLocalMarker()
		{
			TransformLS = new Transform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
