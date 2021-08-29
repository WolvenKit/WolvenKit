using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIISerializableArgumentInstancePS : AIArgumentInstancePS
	{
		private CHandle<ISerializable> _value;

		[Ordinal(1)] 
		[RED("value")] 
		public CHandle<ISerializable> Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
