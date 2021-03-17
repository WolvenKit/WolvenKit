using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickhackBarController : inkWidgetLogicController
	{
		private inkWidgetReference _emptyMask;
		private inkWidgetReference _empty;
		private inkWidgetReference _full;

		[Ordinal(1)] 
		[RED("emptyMask")] 
		public inkWidgetReference EmptyMask
		{
			get => GetProperty(ref _emptyMask);
			set => SetProperty(ref _emptyMask, value);
		}

		[Ordinal(2)] 
		[RED("empty")] 
		public inkWidgetReference Empty
		{
			get => GetProperty(ref _empty);
			set => SetProperty(ref _empty, value);
		}

		[Ordinal(3)] 
		[RED("full")] 
		public inkWidgetReference Full
		{
			get => GetProperty(ref _full);
			set => SetProperty(ref _full, value);
		}

		public QuickhackBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
