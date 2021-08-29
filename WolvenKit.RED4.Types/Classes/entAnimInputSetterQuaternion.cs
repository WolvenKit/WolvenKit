using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimInputSetterQuaternion : entAnimInputSetter
	{
		private Quaternion _value;

		[Ordinal(1)] 
		[RED("value")] 
		public Quaternion Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
