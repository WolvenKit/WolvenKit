using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryStatItem : inkWidgetLogicController
	{
		private wCHandle<inkTextWidget> _label;
		private wCHandle<inkTextWidget> _value;

		[Ordinal(1)] 
		[RED("label")] 
		public wCHandle<inkTextWidget> Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public wCHandle<inkTextWidget> Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public InventoryStatItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
