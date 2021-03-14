using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleWater_ConditionType : questIVehicleConditionType
	{
		private CBool _submergedOnly;
		private CBool _onEnter;

		[Ordinal(0)] 
		[RED("submergedOnly")] 
		public CBool SubmergedOnly
		{
			get
			{
				if (_submergedOnly == null)
				{
					_submergedOnly = (CBool) CR2WTypeManager.Create("Bool", "submergedOnly", cr2w, this);
				}
				return _submergedOnly;
			}
			set
			{
				if (_submergedOnly == value)
				{
					return;
				}
				_submergedOnly = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("onEnter")] 
		public CBool OnEnter
		{
			get
			{
				if (_onEnter == null)
				{
					_onEnter = (CBool) CR2WTypeManager.Create("Bool", "onEnter", cr2w, this);
				}
				return _onEnter;
			}
			set
			{
				if (_onEnter == value)
				{
					return;
				}
				_onEnter = value;
				PropertySet(this);
			}
		}

		public questVehicleWater_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
