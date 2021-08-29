using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterVector : CMaterialParameter
	{
		private Vector4 _vector;

		[Ordinal(2)] 
		[RED("vector")] 
		public Vector4 Vector
		{
			get => GetProperty(ref _vector);
			set => SetProperty(ref _vector, value);
		}
	}
}
