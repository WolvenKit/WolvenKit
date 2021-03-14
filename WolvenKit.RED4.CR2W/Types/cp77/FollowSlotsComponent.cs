using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FollowSlotsComponent : gameScriptableComponent
	{
		private CArray<CHandle<FollowSlot>> _followSlots;

		[Ordinal(5)] 
		[RED("followSlots")] 
		public CArray<CHandle<FollowSlot>> FollowSlots
		{
			get
			{
				if (_followSlots == null)
				{
					_followSlots = (CArray<CHandle<FollowSlot>>) CR2WTypeManager.Create("array:handle:FollowSlot", "followSlots", cr2w, this);
				}
				return _followSlots;
			}
			set
			{
				if (_followSlots == value)
				{
					return;
				}
				_followSlots = value;
				PropertySet(this);
			}
		}

		public FollowSlotsComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
