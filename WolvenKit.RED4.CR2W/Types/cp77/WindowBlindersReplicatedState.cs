using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WindowBlindersReplicatedState : gameDeviceReplicatedState
	{
		private CBool _isOpen;
		private CBool _isTilted;

		[Ordinal(0)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetProperty(ref _isOpen);
			set => SetProperty(ref _isOpen, value);
		}

		[Ordinal(1)] 
		[RED("isTilted")] 
		public CBool IsTilted
		{
			get => GetProperty(ref _isTilted);
			set => SetProperty(ref _isTilted, value);
		}

		public WindowBlindersReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
