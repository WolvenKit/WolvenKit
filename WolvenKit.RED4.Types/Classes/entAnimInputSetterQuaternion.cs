using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimInputSetterQuaternion : entAnimInputSetter
	{
		[Ordinal(1)] 
		[RED("value")] 
		public Quaternion Value
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public entAnimInputSetterQuaternion()
		{
			Value = new() { R = 1.000000F };
		}
	}
}
