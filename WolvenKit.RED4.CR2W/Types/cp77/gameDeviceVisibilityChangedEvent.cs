using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDeviceVisibilityChangedEvent : redEvent
	{
		private CUInt32 _isVisible;

		[Ordinal(0)] 
		[RED("isVisible")] 
		public CUInt32 IsVisible
		{
			get => GetProperty(ref _isVisible);
			set => SetProperty(ref _isVisible, value);
		}

		public gameDeviceVisibilityChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
