using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLineVertex : RedBaseClass
	{
		private Vector2 _int;
		private CEnum<inkLineType> _neType;

		[Ordinal(0)] 
		[RED("int")] 
		public Vector2 Int
		{
			get => GetProperty(ref _int);
			set => SetProperty(ref _int, value);
		}

		[Ordinal(1)] 
		[RED("neType")] 
		public CEnum<inkLineType> NeType
		{
			get => GetProperty(ref _neType);
			set => SetProperty(ref _neType, value);
		}
	}
}
