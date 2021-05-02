using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetControllerSnapshot : CVariable
	{
		private CName _controllerId;
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("controllerId")] 
		public CName ControllerId
		{
			get => GetProperty(ref _controllerId);
			set => SetProperty(ref _controllerId, value);
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		public gameMuppetControllerSnapshot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
