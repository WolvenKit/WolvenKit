using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PachinkoMachine : ArcadeMachine
	{
		private CName _distractionFXName;

		[Ordinal(103)] 
		[RED("distractionFXName")] 
		public CName DistractionFXName
		{
			get => GetProperty(ref _distractionFXName);
			set => SetProperty(ref _distractionFXName, value);
		}

		public PachinkoMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
