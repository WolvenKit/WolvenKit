using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinfluenceBumpReactionSetting : ISerializable
	{
		private CEnum<gameinteractionsBumpIntensity> _reaction;
		private CFloat _maxVelocity;

		[Ordinal(0)] 
		[RED("reaction")] 
		public CEnum<gameinteractionsBumpIntensity> Reaction
		{
			get => GetProperty(ref _reaction);
			set => SetProperty(ref _reaction, value);
		}

		[Ordinal(1)] 
		[RED("maxVelocity")] 
		public CFloat MaxVelocity
		{
			get => GetProperty(ref _maxVelocity);
			set => SetProperty(ref _maxVelocity, value);
		}
	}
}
