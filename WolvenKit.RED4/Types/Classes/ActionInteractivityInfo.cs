using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActionInteractivityInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isExternal")] 
		public CBool IsExternal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isRemote")] 
		public CBool IsRemote
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isDirect")] 
		public CBool IsDirect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ActionInteractivityInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
