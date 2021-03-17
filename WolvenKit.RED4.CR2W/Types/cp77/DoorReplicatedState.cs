using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorReplicatedState : gameDeviceReplicatedState
	{
		private CBool _isOpen;
		private CBool _wasImmediateChange;

		[Ordinal(0)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetProperty(ref _isOpen);
			set => SetProperty(ref _isOpen, value);
		}

		[Ordinal(1)] 
		[RED("wasImmediateChange")] 
		public CBool WasImmediateChange
		{
			get => GetProperty(ref _wasImmediateChange);
			set => SetProperty(ref _wasImmediateChange, value);
		}

		public DoorReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
