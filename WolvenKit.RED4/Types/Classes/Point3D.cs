using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class Point3D : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("x")] 
		public CInt32 X
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("y")] 
		public CInt32 Y
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("z")] 
		public CInt32 Z
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Point3D()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
