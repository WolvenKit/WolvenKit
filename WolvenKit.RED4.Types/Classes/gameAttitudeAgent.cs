using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAttitudeAgent : gameComponent
	{
		private CName _baseAttitudeGroup;

		[Ordinal(4)] 
		[RED("baseAttitudeGroup")] 
		public CName BaseAttitudeGroup
		{
			get => GetProperty(ref _baseAttitudeGroup);
			set => SetProperty(ref _baseAttitudeGroup, value);
		}
	}
}
