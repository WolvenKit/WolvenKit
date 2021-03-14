using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameObjectScanStats : CVariable
	{
		private scannerDataStructure _scannerData;

		[Ordinal(0)] 
		[RED("scannerData")] 
		public scannerDataStructure ScannerData
		{
			get
			{
				if (_scannerData == null)
				{
					_scannerData = (scannerDataStructure) CR2WTypeManager.Create("scannerDataStructure", "scannerData", cr2w, this);
				}
				return _scannerData;
			}
			set
			{
				if (_scannerData == value)
				{
					return;
				}
				_scannerData = value;
				PropertySet(this);
			}
		}

		public GameObjectScanStats(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
