using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MissingWorkspotComponentFailsafeEvent : redEvent
	{
		private entEntityID _playerEntityID;

		[Ordinal(0)] 
		[RED("playerEntityID")] 
		public entEntityID PlayerEntityID
		{
			get => GetProperty(ref _playerEntityID);
			set => SetProperty(ref _playerEntityID, value);
		}

		public MissingWorkspotComponentFailsafeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
