using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHitRepresentationOverride : ISerializable
	{
		private gameHitShapeContainer _represenationOverride;

		[Ordinal(0)] 
		[RED("represenationOverride")] 
		public gameHitShapeContainer RepresenationOverride
		{
			get => GetProperty(ref _represenationOverride);
			set => SetProperty(ref _represenationOverride, value);
		}
	}
}
