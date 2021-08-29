using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsChoiceTypeWrapper : RedBaseClass
	{
		private CUInt32 _properties;

		[Ordinal(0)] 
		[RED("properties")] 
		public CUInt32 Properties
		{
			get => GetProperty(ref _properties);
			set => SetProperty(ref _properties, value);
		}
	}
}
