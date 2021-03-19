using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickhackModule : HUDModule
	{
		private CBool _calculateClose;

		[Ordinal(3)] 
		[RED("calculateClose")] 
		public CBool CalculateClose
		{
			get => GetProperty(ref _calculateClose);
			set => SetProperty(ref _calculateClose, value);
		}

		public QuickhackModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
