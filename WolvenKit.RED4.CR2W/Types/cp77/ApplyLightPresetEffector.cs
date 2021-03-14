using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyLightPresetEffector : gameEffector
	{
		private wCHandle<gameObject> _owner;
		private wCHandle<gamedataLightPreset_Record> _lightPreset;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lightPreset")] 
		public wCHandle<gamedataLightPreset_Record> LightPreset
		{
			get
			{
				if (_lightPreset == null)
				{
					_lightPreset = (wCHandle<gamedataLightPreset_Record>) CR2WTypeManager.Create("whandle:gamedataLightPreset_Record", "lightPreset", cr2w, this);
				}
				return _lightPreset;
			}
			set
			{
				if (_lightPreset == value)
				{
					return;
				}
				_lightPreset = value;
				PropertySet(this);
			}
		}

		public ApplyLightPresetEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
