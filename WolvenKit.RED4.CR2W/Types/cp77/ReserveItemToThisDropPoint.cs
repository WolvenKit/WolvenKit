using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReserveItemToThisDropPoint : ScriptableDeviceAction
	{
		private TweakDBID _item;

		[Ordinal(25)] 
		[RED("item")] 
		public TweakDBID Item
		{
			get
			{
				if (_item == null)
				{
					_item = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "item", cr2w, this);
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

		public ReserveItemToThisDropPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
