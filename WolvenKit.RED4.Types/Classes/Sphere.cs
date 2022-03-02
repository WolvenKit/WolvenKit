using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	[REDClass(SerializeDefault = true)]
	public partial class Sphere : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("CenterRadius2")] 
		public Vector4 CenterRadius2
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public Sphere()
		{
			CenterRadius2 = new();
		}
	}
}
