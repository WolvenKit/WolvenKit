using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreviousMenuData : IScriptable
	{
		private CHandle<OpenMenuRequest> _openMenuRequest;

		[Ordinal(0)] 
		[RED("openMenuRequest")] 
		public CHandle<OpenMenuRequest> OpenMenuRequest
		{
			get => GetProperty(ref _openMenuRequest);
			set => SetProperty(ref _openMenuRequest, value);
		}

		public PreviousMenuData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
