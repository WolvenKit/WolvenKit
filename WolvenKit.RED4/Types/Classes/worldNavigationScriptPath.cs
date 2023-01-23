using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNavigationScriptPath : IScriptable
	{
		[Ordinal(0)] 
		[RED("path")] 
		public CArray<Vector4> Path
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		public worldNavigationScriptPath()
		{
			Path = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
