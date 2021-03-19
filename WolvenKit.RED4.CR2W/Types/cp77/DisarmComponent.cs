using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisarmComponent : gameScriptableComponent
	{
		private CBool _isDisarmingOngoing;
		private wCHandle<gameObject> _owner;
		private wCHandle<gameObject> _requester;

		[Ordinal(5)] 
		[RED("isDisarmingOngoing")] 
		public CBool IsDisarmingOngoing
		{
			get => GetProperty(ref _isDisarmingOngoing);
			set => SetProperty(ref _isDisarmingOngoing, value);
		}

		[Ordinal(6)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(7)] 
		[RED("requester")] 
		public wCHandle<gameObject> Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		public DisarmComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
