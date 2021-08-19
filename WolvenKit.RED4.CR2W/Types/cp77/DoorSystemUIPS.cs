using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorSystemUIPS : VirtualSystemPS
	{
		private CBool _isOpen;

		[Ordinal(108)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetProperty(ref _isOpen);
			set => SetProperty(ref _isOpen, value);
		}

		public DoorSystemUIPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
