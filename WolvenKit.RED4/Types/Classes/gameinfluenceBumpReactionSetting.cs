using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinfluenceBumpReactionSetting : ISerializable
	{
		[Ordinal(0)] 
		[RED("reaction")] 
		public CEnum<gameinteractionsBumpIntensity> Reaction
		{
			get => GetPropertyValue<CEnum<gameinteractionsBumpIntensity>>();
			set => SetPropertyValue<CEnum<gameinteractionsBumpIntensity>>(value);
		}

		[Ordinal(1)] 
		[RED("maxVelocity")] 
		public CFloat MaxVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameinfluenceBumpReactionSetting()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
