using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldgeometryHandIKDescriptionResult : RedBaseClass
	{
		private Vector4 _grabPointStart;
		private Vector4 _grabPointEnd;

		[Ordinal(0)] 
		[RED("grabPointStart")] 
		public Vector4 GrabPointStart
		{
			get => GetProperty(ref _grabPointStart);
			set => SetProperty(ref _grabPointStart, value);
		}

		[Ordinal(1)] 
		[RED("grabPointEnd")] 
		public Vector4 GrabPointEnd
		{
			get => GetProperty(ref _grabPointEnd);
			set => SetProperty(ref _grabPointEnd, value);
		}
	}
}
