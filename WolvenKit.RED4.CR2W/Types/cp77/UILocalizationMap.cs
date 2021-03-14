using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UILocalizationMap : IScriptable
	{
		private CArray<UILocRecord> _map;

		[Ordinal(0)] 
		[RED("map")] 
		public CArray<UILocRecord> Map
		{
			get
			{
				if (_map == null)
				{
					_map = (CArray<UILocRecord>) CR2WTypeManager.Create("array:UILocRecord", "map", cr2w, this);
				}
				return _map;
			}
			set
			{
				if (_map == value)
				{
					return;
				}
				_map = value;
				PropertySet(this);
			}
		}

		public UILocalizationMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
