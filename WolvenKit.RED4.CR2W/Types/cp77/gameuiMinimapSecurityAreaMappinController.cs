using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapSecurityAreaMappinController : gameuiBaseMinimapMappinController
	{
		private CBool _playerInArea;
		private CHandle<gamemappinsIArea> _area;
		private inkShapeWidgetReference _areaShapeWidget;

		[Ordinal(14)] 
		[RED("playerInArea")] 
		public CBool PlayerInArea
		{
			get => GetProperty(ref _playerInArea);
			set => SetProperty(ref _playerInArea, value);
		}

		[Ordinal(15)] 
		[RED("area")] 
		public CHandle<gamemappinsIArea> Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		[Ordinal(16)] 
		[RED("areaShapeWidget")] 
		public inkShapeWidgetReference AreaShapeWidget
		{
			get => GetProperty(ref _areaShapeWidget);
			set => SetProperty(ref _areaShapeWidget, value);
		}

		public gameuiMinimapSecurityAreaMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
