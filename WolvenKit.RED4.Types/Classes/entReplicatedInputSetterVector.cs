using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entReplicatedInputSetterVector : entReplicatedInputSetterBase
	{
		[Ordinal(2)] 
		[RED("value")] 
		public Vector4 Value
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public entReplicatedInputSetterVector()
		{
			Value = new();
		}
	}
}
