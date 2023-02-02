using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JunkItemRecord : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("junkItemID")] 
		public TweakDBID JunkItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public JunkItemRecord()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
