using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CanNPCRun : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("maxRunners")] 
		public CInt32 MaxRunners
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public CanNPCRun()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
