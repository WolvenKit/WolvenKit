using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropQueueUpdatedEvent : redEvent
	{
		private CArray<gameItemModParams> _dropQueue;

		[Ordinal(0)] 
		[RED("dropQueue")] 
		public CArray<gameItemModParams> DropQueue
		{
			get
			{
				if (_dropQueue == null)
				{
					_dropQueue = (CArray<gameItemModParams>) CR2WTypeManager.Create("array:gameItemModParams", "dropQueue", cr2w, this);
				}
				return _dropQueue;
			}
			set
			{
				if (_dropQueue == value)
				{
					return;
				}
				_dropQueue = value;
				PropertySet(this);
			}
		}

		public DropQueueUpdatedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
