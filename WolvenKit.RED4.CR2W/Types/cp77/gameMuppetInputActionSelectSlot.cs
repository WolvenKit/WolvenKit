using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionSelectSlot : gameIMuppetInputAction
	{
		private CInt32 _targetSlot;

		[Ordinal(0)] 
		[RED("targetSlot")] 
		public CInt32 TargetSlot
		{
			get => GetProperty(ref _targetSlot);
			set => SetProperty(ref _targetSlot, value);
		}

		public gameMuppetInputActionSelectSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
