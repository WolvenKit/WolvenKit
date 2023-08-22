using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class graphGraphNodeDefinition : graphIGraphObjectDefinition
	{
		[Ordinal(0)] 
		[RED("sockets")] 
		public CArray<CHandle<graphGraphSocketDefinition>> Sockets
		{
			get => GetPropertyValue<CArray<CHandle<graphGraphSocketDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<graphGraphSocketDefinition>>>(value);
		}

		public graphGraphNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
