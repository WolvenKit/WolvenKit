using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEntitySpawnerSlotData : CVariable
	{
		private CName _slotName;
		private TweakDBID _spawnableObject;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("spawnableObject")] 
		public TweakDBID SpawnableObject
		{
			get
			{
				if (_spawnableObject == null)
				{
					_spawnableObject = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "spawnableObject", cr2w, this);
				}
				return _spawnableObject;
			}
			set
			{
				if (_spawnableObject == value)
				{
					return;
				}
				_spawnableObject = value;
				PropertySet(this);
			}
		}

		public gameEntitySpawnerSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
