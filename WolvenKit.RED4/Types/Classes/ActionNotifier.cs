using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActionNotifier : IScriptable
	{
		[Ordinal(0)] 
		[RED("external")] 
		public CBool External
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("internal")] 
		public CBool Internal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("failed")] 
		public CBool Failed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ActionNotifier()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
