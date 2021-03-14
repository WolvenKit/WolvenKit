using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIEntityLost : AIAIEvent
	{
		private wCHandle<entEntity> _spotter;
		private wCHandle<entEntity> _spotted;
		private CBool _isHostile;

		[Ordinal(2)] 
		[RED("spotter")] 
		public wCHandle<entEntity> Spotter
		{
			get
			{
				if (_spotter == null)
				{
					_spotter = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "spotter", cr2w, this);
				}
				return _spotter;
			}
			set
			{
				if (_spotter == value)
				{
					return;
				}
				_spotter = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("spotted")] 
		public wCHandle<entEntity> Spotted
		{
			get
			{
				if (_spotted == null)
				{
					_spotted = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "spotted", cr2w, this);
				}
				return _spotted;
			}
			set
			{
				if (_spotted == value)
				{
					return;
				}
				_spotted = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isHostile")] 
		public CBool IsHostile
		{
			get
			{
				if (_isHostile == null)
				{
					_isHostile = (CBool) CR2WTypeManager.Create("Bool", "isHostile", cr2w, this);
				}
				return _isHostile;
			}
			set
			{
				if (_isHostile == value)
				{
					return;
				}
				_isHostile = value;
				PropertySet(this);
			}
		}

		public AIEntityLost(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
