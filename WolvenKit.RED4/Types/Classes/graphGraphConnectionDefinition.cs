using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class graphGraphConnectionDefinition : graphIGraphObjectDefinition
	{
		[Ordinal(0)] 
		[RED("source")] 
		public CWeakHandle<graphGraphSocketDefinition> Source
		{
			get => GetPropertyValue<CWeakHandle<graphGraphSocketDefinition>>();
			set => SetPropertyValue<CWeakHandle<graphGraphSocketDefinition>>(value);
		}

		[Ordinal(1)] 
		[RED("destination")] 
		public CWeakHandle<graphGraphSocketDefinition> Destination
		{
			get => GetPropertyValue<CWeakHandle<graphGraphSocketDefinition>>();
			set => SetPropertyValue<CWeakHandle<graphGraphSocketDefinition>>(value);
		}

		public graphGraphConnectionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
