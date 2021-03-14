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
			get
			{
				if (_shardTitle == null)
				{
					_shardTitle = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "shardTitle", cr2w, this);
				}
				return _shardTitle;
			}
			set
			{
				if (_shardTitle == value)
				{
					return;
				}
				_shardTitle = value;
				PropertySet(this);
			}
		}

		public ShardCollectedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
