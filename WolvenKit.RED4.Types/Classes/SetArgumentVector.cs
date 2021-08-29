using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetArgumentVector : SetArguments
	{
		private CHandle<AIArgumentMapping> _newValue;

		[Ordinal(1)] 
		[RED("newValue")] 
		public CHandle<AIArgumentMapping> NewValue
		{
			get => GetProperty(ref _newValue);
			set => SetProperty(ref _newValue, value);
		}
	}
}
