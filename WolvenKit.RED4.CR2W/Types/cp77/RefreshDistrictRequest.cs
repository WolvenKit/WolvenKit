using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshDistrictRequest : gameScriptableSystemRequest
	{
		private wCHandle<gamedataDistrictPreventionData_Record> _preventionPreset;

		[Ordinal(0)] 
		[RED("preventionPreset")] 
		public wCHandle<gamedataDistrictPreventionData_Record> PreventionPreset
		{
			get
			{
				if (_preventionPreset == null)
				{
					_preventionPreset = (wCHandle<gamedataDistrictPreventionData_Record>) CR2WTypeManager.Create("whandle:gamedataDistrictPreventionData_Record", "preventionPreset", cr2w, this);
				}
				return _preventionPreset;
			}
			set
			{
				if (_preventionPreset == value)
				{
					return;
				}
				_preventionPreset = value;
				PropertySet(this);
			}
		}

		public RefreshDistrictRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
