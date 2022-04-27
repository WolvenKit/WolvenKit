using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimDefinition : IScriptable
	{
		[Ordinal(0)] 
		[RED("interpolators")] 
		public CArray<CHandle<inkanimInterpolator>> Interpolators
		{
			get => GetPropertyValue<CArray<CHandle<inkanimInterpolator>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimInterpolator>>>(value);
		}

		[Ordinal(1)] 
		[RED("events")] 
		public CArray<CHandle<inkanimEvent>> Events
		{
			get => GetPropertyValue<CArray<CHandle<inkanimEvent>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimEvent>>>(value);
		}

		public inkanimDefinition()
		{
			Interpolators = new();
			Events = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
