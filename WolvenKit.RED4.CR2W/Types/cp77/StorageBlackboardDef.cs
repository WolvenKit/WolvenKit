using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StorageBlackboardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _storageData;

		[Ordinal(0)] 
		[RED("StorageData")] 
		public gamebbScriptID_Variant StorageData
		{
			get
			{
				if (_storageData == null)
				{
					_storageData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "StorageData", cr2w, this);
				}
				return _storageData;
			}
			set
			{
				if (_storageData == value)
				{
					return;
				}
				_storageData = value;
				PropertySet(this);
			}
		}

		public StorageBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
