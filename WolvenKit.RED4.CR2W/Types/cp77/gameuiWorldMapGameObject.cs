using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapGameObject : gameObject
	{
		private CArray<gameuiDistrictTriggerData> _districts;

		[Ordinal(40)] 
		[RED("districts")] 
		public CArray<gameuiDistrictTriggerData> Districts
		{
			get
			{
				if (_districts == null)
				{
					_districts = (CArray<gameuiDistrictTriggerData>) CR2WTypeManager.Create("array:gameuiDistrictTriggerData", "districts", cr2w, this);
				}
				return _districts;
			}
			set
			{
				if (_districts == value)
				{
					return;
				}
				_districts = value;
				PropertySet(this);
			}
		}

		public gameuiWorldMapGameObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
