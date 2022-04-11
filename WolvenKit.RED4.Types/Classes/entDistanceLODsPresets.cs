using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entDistanceLODsPresets : ISerializable
	{
		[Ordinal(0)] 
		[RED("definitions", 4)] 
		public CStatic<entLODDefinition> Definitions
		{
			get => GetPropertyValue<CStatic<entLODDefinition>>();
			set => SetPropertyValue<CStatic<entLODDefinition>>(value);
		}

		public entDistanceLODsPresets()
		{
			Definitions = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
