using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entIKTargetRemoveEvent : redEvent
	{
		private animIKTargetRef _ikTargetRef;

		[Ordinal(0)] 
		[RED("ikTargetRef")] 
		public animIKTargetRef IkTargetRef
		{
			get => GetProperty(ref _ikTargetRef);
			set => SetProperty(ref _ikTargetRef, value);
		}

		public entIKTargetRemoveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
