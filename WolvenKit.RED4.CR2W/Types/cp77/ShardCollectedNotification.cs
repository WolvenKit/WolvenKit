using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardCollectedNotification : GenericNotificationController
	{
		private inkTextWidgetReference _shardTitle;

		[Ordinal(12)] 
		[RED("shardTitle")] 
		public inkTextWidgetReference ShardTitle
		{
			get => GetProperty(ref _shardTitle);
			set => SetProperty(ref _shardTitle, value);
		}

		public ShardCollectedNotification(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
