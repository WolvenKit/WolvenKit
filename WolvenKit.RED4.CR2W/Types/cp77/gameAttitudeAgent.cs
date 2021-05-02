using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttitudeAgent : gameComponent
	{
		private CName _baseAttitudeGroup;

		[Ordinal(4)] 
		[RED("baseAttitudeGroup")] 
		public CName BaseAttitudeGroup
		{
			get => GetProperty(ref _baseAttitudeGroup);
			set => SetProperty(ref _baseAttitudeGroup, value);
		}

		public gameAttitudeAgent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
