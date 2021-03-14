using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReloadEvents : WeaponEventsTransition
	{
		private CHandle<AnimFeature_SelectRandomAnimSync> _randomSync;
		private CBool _sprintingLastUpdate;
		private CBool _uninteruptibleSet;

		[Ordinal(0)] 
		[RED("randomSync")] 
		public CHandle<AnimFeature_SelectRandomAnimSync> RandomSync
		{
			get
			{
				if (_randomSync == null)
				{
					_randomSync = (CHandle<AnimFeature_SelectRandomAnimSync>) CR2WTypeManager.Create("handle:AnimFeature_SelectRandomAnimSync", "randomSync", cr2w, this);
				}
				return _randomSync;
			}
			set
			{
				if (_randomSync == value)
				{
					return;
				}
				_randomSync = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sprintingLastUpdate")] 
		public CBool SprintingLastUpdate
		{
			get
			{
				if (_sprintingLastUpdate == null)
				{
					_sprintingLastUpdate = (CBool) CR2WTypeManager.Create("Bool", "sprintingLastUpdate", cr2w, this);
				}
				return _sprintingLastUpdate;
			}
			set
			{
				if (_sprintingLastUpdate == value)
				{
					return;
				}
				_sprintingLastUpdate = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("uninteruptibleSet")] 
		public CBool UninteruptibleSet
		{
			get
			{
				if (_uninteruptibleSet == null)
				{
					_uninteruptibleSet = (CBool) CR2WTypeManager.Create("Bool", "uninteruptibleSet", cr2w, this);
				}
				return _uninteruptibleSet;
			}
			set
			{
				if (_uninteruptibleSet == value)
				{
					return;
				}
				_uninteruptibleSet = value;
				PropertySet(this);
			}
		}

		public ReloadEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
