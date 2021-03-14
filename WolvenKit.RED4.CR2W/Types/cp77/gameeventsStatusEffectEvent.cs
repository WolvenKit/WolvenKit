using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsStatusEffectEvent : redEvent
	{
		private CHandle<gamedataStatusEffect_Record> _staticData;
		private CUInt32 _stackCount;

		[Ordinal(0)] 
		[RED("staticData")] 
		public CHandle<gamedataStatusEffect_Record> StaticData
		{
			get
			{
				if (_staticData == null)
				{
					_staticData = (CHandle<gamedataStatusEffect_Record>) CR2WTypeManager.Create("handle:gamedataStatusEffect_Record", "staticData", cr2w, this);
				}
				return _staticData;
			}
			set
			{
				if (_staticData == value)
				{
					return;
				}
				_staticData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stackCount")] 
		public CUInt32 StackCount
		{
			get
			{
				if (_stackCount == null)
				{
					_stackCount = (CUInt32) CR2WTypeManager.Create("Uint32", "stackCount", cr2w, this);
				}
				return _stackCount;
			}
			set
			{
				if (_stackCount == value)
				{
					return;
				}
				_stackCount = value;
				PropertySet(this);
			}
		}

		public gameeventsStatusEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
