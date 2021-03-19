using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMinimizeCallRequest : gameScriptableSystemRequest
	{
		private CBool _minimized;

		[Ordinal(0)] 
		[RED("minimized")] 
		public CBool Minimized
		{
			get => GetProperty(ref _minimized);
			set => SetProperty(ref _minimized, value);
		}

		public questMinimizeCallRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
