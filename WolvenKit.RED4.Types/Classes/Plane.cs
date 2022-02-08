using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Plane : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("NormalDistance")] 
		public Vector4 NormalDistance
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public Plane()
		{
			NormalDistance = new();
		}
	}
}
