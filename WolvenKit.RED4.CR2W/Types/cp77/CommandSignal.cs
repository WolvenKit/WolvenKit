using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CommandSignal : gameTaggedSignalUserData
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

		public CommandSignal(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
