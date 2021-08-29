using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CommandSignal : gameTaggedSignalUserData
	{
		private CBool _track;
		private CArray<CName> _commandClassNames;

		[Ordinal(1)] 
		[RED("track")] 
		public CBool Track
		{
			get => GetProperty(ref _track);
			set => SetProperty(ref _track, value);
		}

		[Ordinal(2)] 
		[RED("commandClassNames")] 
		public CArray<CName> CommandClassNames
		{
			get => GetProperty(ref _commandClassNames);
			set => SetProperty(ref _commandClassNames, value);
		}
	}
}
