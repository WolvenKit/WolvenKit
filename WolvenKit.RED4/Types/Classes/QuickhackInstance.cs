using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickhackInstance : ModuleInstance
	{
		[Ordinal(6)] 
		[RED("open")] 
		public CBool Open
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("process")] 
		public CBool Process
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuickhackInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
