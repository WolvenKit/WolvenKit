using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeTimeoutDefinition : AICTreeExtendableNodeDefinition
	{
		private CFloat _timeout;

		[Ordinal(1)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetProperty(ref _timeout);
			set => SetProperty(ref _timeout, value);
		}

		public AICTreeNodeTimeoutDefinition()
		{
			_timeout = 1.000000F;
		}
	}
}
