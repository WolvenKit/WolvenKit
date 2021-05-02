using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SCustomDeviceActionsData : CVariable
	{
		private CArray<SDeviceActionCustomData> _actions;

		[Ordinal(0)] 
		[RED("actions")] 
		public CArray<SDeviceActionCustomData> Actions
		{
			get => GetProperty(ref _actions);
			set => SetProperty(ref _actions, value);
		}

		public SCustomDeviceActionsData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
