using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_WeaponUser : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("ikLeftHandLocalPosition")] 
		public Vector4 IkLeftHandLocalPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("ikRightHandLocalPosition")] 
		public Vector4 IkRightHandLocalPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public animAnimFeature_WeaponUser()
		{
			IkLeftHandLocalPosition = new() { W = 1.000000F };
			IkRightHandLocalPosition = new() { W = 1.000000F };
		}
	}
}
