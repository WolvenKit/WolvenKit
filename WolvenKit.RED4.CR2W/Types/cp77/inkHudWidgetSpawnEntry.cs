using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkHudWidgetSpawnEntry : CVariable
	{
		private CName _hudEntryName;
		private CBool _enabled;
		private CEnum<worlduiContextVisibility> _contextVisibility;
		private CEnum<gameuiContext> _gameContextVisibility;
		private CEnum<inkSpawnMode> _spawnMode;
		private rRef<inkWidgetLibraryResource> _widgetResource;
		private CEnum<inkEAnchor> _anchorPlace;
		private Vector2 _anchorPoint;
		private inkMargin _margins;
		private CBool _attachToSlot;
		private inkWidgetSlotAttachmentParams _slotParams;
		private CBool _useSeparateWindow;
		private CBool _affectedByGlitchEffect;
		private CBool _spawnBeforeSlots;

		[Ordinal(0)] 
		[RED("hudEntryName")] 
		public CName HudEntryName
		{
			get => GetProperty(ref _hudEntryName);
			set => SetProperty(ref _hudEntryName, value);
		}

		[Ordinal(1)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(2)] 
		[RED("contextVisibility")] 
		public CEnum<worlduiContextVisibility> ContextVisibility
		{
			get => GetProperty(ref _contextVisibility);
			set => SetProperty(ref _contextVisibility, value);
		}

		[Ordinal(3)] 
		[RED("gameContextVisibility")] 
		public CEnum<gameuiContext> GameContextVisibility
		{
			get => GetProperty(ref _gameContextVisibility);
			set => SetProperty(ref _gameContextVisibility, value);
		}

		[Ordinal(4)] 
		[RED("spawnMode")] 
		public CEnum<inkSpawnMode> SpawnMode
		{
			get => GetProperty(ref _spawnMode);
			set => SetProperty(ref _spawnMode, value);
		}

		[Ordinal(5)] 
		[RED("widgetResource")] 
		public rRef<inkWidgetLibraryResource> WidgetResource
		{
			get => GetProperty(ref _widgetResource);
			set => SetProperty(ref _widgetResource, value);
		}

		[Ordinal(6)] 
		[RED("anchorPlace")] 
		public CEnum<inkEAnchor> AnchorPlace
		{
			get => GetProperty(ref _anchorPlace);
			set => SetProperty(ref _anchorPlace, value);
		}

		[Ordinal(7)] 
		[RED("anchorPoint")] 
		public Vector2 AnchorPoint
		{
			get => GetProperty(ref _anchorPoint);
			set => SetProperty(ref _anchorPoint, value);
		}

		[Ordinal(8)] 
		[RED("margins")] 
		public inkMargin Margins
		{
			get => GetProperty(ref _margins);
			set => SetProperty(ref _margins, value);
		}

		[Ordinal(9)] 
		[RED("attachToSlot")] 
		public CBool AttachToSlot
		{
			get => GetProperty(ref _attachToSlot);
			set => SetProperty(ref _attachToSlot, value);
		}

		[Ordinal(10)] 
		[RED("slotParams")] 
		public inkWidgetSlotAttachmentParams SlotParams
		{
			get => GetProperty(ref _slotParams);
			set => SetProperty(ref _slotParams, value);
		}

		[Ordinal(11)] 
		[RED("useSeparateWindow")] 
		public CBool UseSeparateWindow
		{
			get => GetProperty(ref _useSeparateWindow);
			set => SetProperty(ref _useSeparateWindow, value);
		}

		[Ordinal(12)] 
		[RED("affectedByGlitchEffect")] 
		public CBool AffectedByGlitchEffect
		{
			get => GetProperty(ref _affectedByGlitchEffect);
			set => SetProperty(ref _affectedByGlitchEffect, value);
		}

		[Ordinal(13)] 
		[RED("spawnBeforeSlots")] 
		public CBool SpawnBeforeSlots
		{
			get => GetProperty(ref _spawnBeforeSlots);
			set => SetProperty(ref _spawnBeforeSlots, value);
		}

		public inkHudWidgetSpawnEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
