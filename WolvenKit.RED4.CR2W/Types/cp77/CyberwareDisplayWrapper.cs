using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareDisplayWrapper : IScriptable
	{
		private InventoryItemDisplayData _displayData;

		[Ordinal(0)] 
		[RED("displayData")] 
		public InventoryItemDisplayData DisplayData
		{
			get => GetProperty(ref _displayData);
			set => SetProperty(ref _displayData, value);
		}

		public CyberwareDisplayWrapper(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
