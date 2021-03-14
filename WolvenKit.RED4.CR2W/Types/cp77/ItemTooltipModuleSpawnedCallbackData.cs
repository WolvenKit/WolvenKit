using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipModuleSpawnedCallbackData : IScriptable
	{
		private CName _moduleName;

		[Ordinal(0)] 
		[RED("moduleName")] 
		public CName ModuleName
		{
			get
			{
				if (_moduleName == null)
				{
					_moduleName = (CName) CR2WTypeManager.Create("CName", "moduleName", cr2w, this);
				}
				return _moduleName;
			}
			set
			{
				if (_moduleName == value)
				{
					return;
				}
				_moduleName = value;
				PropertySet(this);
			}
		}

		public ItemTooltipModuleSpawnedCallbackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
