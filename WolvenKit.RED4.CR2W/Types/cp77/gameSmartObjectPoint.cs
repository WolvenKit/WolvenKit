using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectPoint : CVariable
	{
		private CBool _isReachable;

		[Ordinal(0)] 
		[RED("isReachable")] 
		public CBool IsReachable
		{
			get => GetProperty(ref _isReachable);
			set => SetProperty(ref _isReachable, value);
		}

		public gameSmartObjectPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
