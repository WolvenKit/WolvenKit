using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineeventPostponedParameterVector : gamestateMachineeventPostponedParameterBase
	{
		[Ordinal(2)] 
		[RED("value")] 
		public Vector4 Value
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gamestateMachineeventPostponedParameterVector()
		{
			Value = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
