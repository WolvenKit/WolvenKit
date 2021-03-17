using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeHalfLights : redEvent
	{
		private CBool _isAuthorization;

		[Ordinal(0)] 
		[RED("isAuthorization")] 
		public CBool IsAuthorization
		{
			get => GetProperty(ref _isAuthorization);
			set => SetProperty(ref _isAuthorization, value);
		}

		public ChangeHalfLights(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
