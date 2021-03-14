using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldRenderAreaSettings : CVariable
	{
		private CArray<CHandle<IAreaSettings>> _areaParameters;

		[Ordinal(0)] 
		[RED("areaParameters")] 
		public CArray<CHandle<IAreaSettings>> AreaParameters
		{
			get
			{
				if (_areaParameters == null)
				{
					_areaParameters = (CArray<CHandle<IAreaSettings>>) CR2WTypeManager.Create("array:handle:IAreaSettings", "areaParameters", cr2w, this);
				}
				return _areaParameters;
			}
			set
			{
				if (_areaParameters == value)
				{
					return;
				}
				_areaParameters = value;
				PropertySet(this);
			}
		}

		public WorldRenderAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
