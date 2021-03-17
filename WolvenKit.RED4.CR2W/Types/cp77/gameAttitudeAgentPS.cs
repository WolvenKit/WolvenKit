using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttitudeAgentPS : gameComponentPS
	{
		private CName _currentAttitudeGroup;

		[Ordinal(0)] 
		[RED("currentAttitudeGroup")] 
		public CName CurrentAttitudeGroup
		{
			get => GetProperty(ref _currentAttitudeGroup);
			set => SetProperty(ref _currentAttitudeGroup, value);
		}

		public gameAttitudeAgentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
