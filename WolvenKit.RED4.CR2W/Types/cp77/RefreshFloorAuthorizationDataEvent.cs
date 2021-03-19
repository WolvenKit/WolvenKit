using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshFloorAuthorizationDataEvent : redEvent
	{
		private CBool _passToEntity;

		[Ordinal(0)] 
		[RED("passToEntity")] 
		public CBool PassToEntity
		{
			get => GetProperty(ref _passToEntity);
			set => SetProperty(ref _passToEntity, value);
		}

		public RefreshFloorAuthorizationDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
