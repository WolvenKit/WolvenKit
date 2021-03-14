using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveGlobalDeathCondition : AIbehaviorexpressionScript
	{
		private CUInt32 _onDeathCbId;

		[Ordinal(0)] 
		[RED("onDeathCbId")] 
		public CUInt32 OnDeathCbId
		{
			get
			{
				if (_onDeathCbId == null)
				{
					_onDeathCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "onDeathCbId", cr2w, this);
				}
				return _onDeathCbId;
			}
			set
			{
				if (_onDeathCbId == value)
				{
					return;
				}
				_onDeathCbId = value;
				PropertySet(this);
			}
		}

		public PassiveGlobalDeathCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
