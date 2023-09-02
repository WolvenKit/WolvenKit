using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RevealNetworkGridEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("shouldDraw")] 
		public CBool ShouldDraw
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("ownerEntityPosition")] 
		public Vector4 OwnerEntityPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("fxDefault")] 
		public gameFxResource FxDefault
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(3)] 
		[RED("fxBreached")] 
		public gameFxResource FxBreached
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(4)] 
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RevealNetworkGridEvent()
		{
			OwnerEntityPosition = new Vector4();
			FxDefault = new gameFxResource();
			FxBreached = new gameFxResource();
			RevealSlave = true;
			RevealMaster = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
