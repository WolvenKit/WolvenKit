using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Sample_Replicated_Serializable : ISerializable
	{
		[Ordinal(0)] 
		[RED("property")] 
		public CBool Property
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public Sample_Replicated_Serializable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
