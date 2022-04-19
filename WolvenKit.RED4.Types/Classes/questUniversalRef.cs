using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questUniversalRef : ISerializable
	{
		[Ordinal(0)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("refLocalPlayer")] 
		public CBool RefLocalPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("mainPlayerObject")] 
		public CBool MainPlayerObject
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questUniversalRef()
		{
			EntityReference = new() { Names = new() };
			RefLocalPlayer = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
