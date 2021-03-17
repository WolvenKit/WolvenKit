using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareTabModsRequest : redEvent
	{
		private CBool _open;
		private CHandle<CyberwareDisplayWrapper> _wrapper;

		[Ordinal(0)] 
		[RED("open")] 
		public CBool Open
		{
			get => GetProperty(ref _open);
			set => SetProperty(ref _open, value);
		}

		[Ordinal(1)] 
		[RED("wrapper")] 
		public CHandle<CyberwareDisplayWrapper> Wrapper
		{
			get => GetProperty(ref _wrapper);
			set => SetProperty(ref _wrapper, value);
		}

		public CyberwareTabModsRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
