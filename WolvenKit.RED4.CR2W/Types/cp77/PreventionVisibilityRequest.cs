using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionVisibilityRequest : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _requester;
		private CBool _seePlayer;

		[Ordinal(0)] 
		[RED("requester")] 
		public wCHandle<gameObject> Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		[Ordinal(1)] 
		[RED("seePlayer")] 
		public CBool SeePlayer
		{
			get => GetProperty(ref _seePlayer);
			set => SetProperty(ref _seePlayer, value);
		}

		public PreventionVisibilityRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
