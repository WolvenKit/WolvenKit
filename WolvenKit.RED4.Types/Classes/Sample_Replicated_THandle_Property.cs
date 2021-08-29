using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_Replicated_THandle_Property : RedBaseClass
	{
		private CHandle<Sample_Replicated_Serializable> _property;

		[Ordinal(0)] 
		[RED("property")] 
		public CHandle<Sample_Replicated_Serializable> Property
		{
			get => GetProperty(ref _property);
			set => SetProperty(ref _property, value);
		}
	}
}
