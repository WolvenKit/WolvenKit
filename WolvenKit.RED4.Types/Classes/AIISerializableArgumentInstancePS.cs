using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIISerializableArgumentInstancePS : AIArgumentInstancePS
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CHandle<ISerializable> Value
		{
			get => GetPropertyValue<CHandle<ISerializable>>();
			set => SetPropertyValue<CHandle<ISerializable>>(value);
		}

		public AIISerializableArgumentInstancePS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
