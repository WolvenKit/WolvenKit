using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveStatusEffectEvent : redEvent
	{
		private TweakDBID _effectID;
		private CUInt32 _removeCount;

		[Ordinal(0)] 
		[RED("effectID")] 
		public TweakDBID EffectID
		{
			get
			{
				if (_effectID == null)
				{
					_effectID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "effectID", cr2w, this);
				}
				return _effectID;
			}
			set
			{
				if (_effectID == value)
				{
					return;
				}
				_effectID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("removeCount")] 
		public CUInt32 RemoveCount
		{
			get
			{
				if (_removeCount == null)
				{
					_removeCount = (CUInt32) CR2WTypeManager.Create("Uint32", "removeCount", cr2w, this);
				}
				return _removeCount;
			}
			set
			{
				if (_removeCount == value)
				{
					return;
				}
				_removeCount = value;
				PropertySet(this);
			}
		}

		public RemoveStatusEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
