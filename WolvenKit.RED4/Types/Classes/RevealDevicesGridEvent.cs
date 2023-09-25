using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RevealDevicesGridEvent : redEvent
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
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RevealDevicesGridEvent()
		{
			OwnerEntityPosition = new Vector4();
			FxDefault = new gameFxResource();
			RevealSlave = true;
			RevealMaster = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
