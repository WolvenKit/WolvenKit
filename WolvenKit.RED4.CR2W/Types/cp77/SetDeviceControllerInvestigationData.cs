using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDeviceControllerInvestigationData : AIbehaviortaskScript
	{
		private wCHandle<ScriptedPuppet> _ownerPuppet;

		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public wCHandle<ScriptedPuppet> OwnerPuppet
		{
			get => GetProperty(ref _ownerPuppet);
			set => SetProperty(ref _ownerPuppet, value);
		}

		public SetDeviceControllerInvestigationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
