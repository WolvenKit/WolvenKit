using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardCaseAnimationEnded : redEvent
	{
		private wCHandle<gameObject> _activator;
		private gameItemID _item;
		private CBool _read;

		[Ordinal(0)] 
		[RED("activator")] 
		public wCHandle<gameObject> Activator
		{
			get
			{
				if (_activator == null)
				{
					_activator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "activator", cr2w, this);
				}
				return _activator;
			}
			set
			{
				if (_activator == value)
				{
					return;
				}
				_activator = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("item")] 
		public gameItemID Item
		{
			get
			{
				if (_item == null)
				{
					_item = (gameItemID) CR2WTypeManager.Create("gameItemID", "item", cr2w, this);
				}
				return _item;
			}
			set
			{
				if (_item == value)
				{
					return;
				}
				_item = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("read")] 
		public CBool Read_
		{
			get
			{
				if (_read == null)
				{
					_read = (CBool) CR2WTypeManager.Create("Bool", "read", cr2w, this);
				}
				return _read;
			}
			set
			{
				if (_read == value)
				{
					return;
				}
				_read = value;
				PropertySet(this);
			}
		}

		public ShardCaseAnimationEnded(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
