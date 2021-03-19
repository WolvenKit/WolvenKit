using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPinInfo : CVariable
	{
		private CBool _shouldShow;
		private CBool _showFloorAbove;
		private CBool _showFloorBelow;
		private CInt32 _iconType;
		private CFloat _offset;
		private CString _displayText;

		[Ordinal(0)] 
		[RED("shouldShow")] 
		public CBool ShouldShow
		{
			get => GetProperty(ref _shouldShow);
			set => SetProperty(ref _shouldShow, value);
		}

		[Ordinal(1)] 
		[RED("showFloorAbove")] 
		public CBool ShowFloorAbove
		{
			get => GetProperty(ref _showFloorAbove);
			set => SetProperty(ref _showFloorAbove, value);
		}

		[Ordinal(2)] 
		[RED("showFloorBelow")] 
		public CBool ShowFloorBelow
		{
			get => GetProperty(ref _showFloorBelow);
			set => SetProperty(ref _showFloorBelow, value);
		}

		[Ordinal(3)] 
		[RED("iconType")] 
		public CInt32 IconType
		{
			get => GetProperty(ref _iconType);
			set => SetProperty(ref _iconType, value);
		}

		[Ordinal(4)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(5)] 
		[RED("displayText")] 
		public CString DisplayText
		{
			get => GetProperty(ref _displayText);
			set => SetProperty(ref _displayText, value);
		}

		public gameuiPinInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
