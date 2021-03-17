using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationPersistantElements : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _headerHolder;
		private inkWidgetReference _lBBtn;
		private inkWidgetReference _rBBtn;
		private inkCompoundWidgetReference _fluffHolderRight;
		private inkCompoundWidgetReference _fluffHolderDown;
		private inkCompoundWidgetReference _fluffHolderLeft;
		private inkTextWidgetReference _fluffText1;
		private inkTextWidgetReference _fluffTextRight;
		private inkTextWidgetReference _fluffTextDown;
		private inkTextWidgetReference _fluffTextLeft;
		private CArray<CHandle<CharacterCreationTopBarHeader>> _headers;
		private CHandle<CharacterCreationTopBarHeader> _selectedHeader;
		private CFloat _c_fluffMaxX;
		private CFloat _c_fluffMinY;
		private CFloat _c_fluffMaxY;

		[Ordinal(1)] 
		[RED("headerHolder")] 
		public inkCompoundWidgetReference HeaderHolder
		{
			get => GetProperty(ref _headerHolder);
			set => SetProperty(ref _headerHolder, value);
		}

		[Ordinal(2)] 
		[RED("LBBtn")] 
		public inkWidgetReference LBBtn
		{
			get => GetProperty(ref _lBBtn);
			set => SetProperty(ref _lBBtn, value);
		}

		[Ordinal(3)] 
		[RED("RBBtn")] 
		public inkWidgetReference RBBtn
		{
			get => GetProperty(ref _rBBtn);
			set => SetProperty(ref _rBBtn, value);
		}

		[Ordinal(4)] 
		[RED("fluffHolderRight")] 
		public inkCompoundWidgetReference FluffHolderRight
		{
			get => GetProperty(ref _fluffHolderRight);
			set => SetProperty(ref _fluffHolderRight, value);
		}

		[Ordinal(5)] 
		[RED("fluffHolderDown")] 
		public inkCompoundWidgetReference FluffHolderDown
		{
			get => GetProperty(ref _fluffHolderDown);
			set => SetProperty(ref _fluffHolderDown, value);
		}

		[Ordinal(6)] 
		[RED("fluffHolderLeft")] 
		public inkCompoundWidgetReference FluffHolderLeft
		{
			get => GetProperty(ref _fluffHolderLeft);
			set => SetProperty(ref _fluffHolderLeft, value);
		}

		[Ordinal(7)] 
		[RED("fluffText1")] 
		public inkTextWidgetReference FluffText1
		{
			get => GetProperty(ref _fluffText1);
			set => SetProperty(ref _fluffText1, value);
		}

		[Ordinal(8)] 
		[RED("fluffTextRight")] 
		public inkTextWidgetReference FluffTextRight
		{
			get => GetProperty(ref _fluffTextRight);
			set => SetProperty(ref _fluffTextRight, value);
		}

		[Ordinal(9)] 
		[RED("fluffTextDown")] 
		public inkTextWidgetReference FluffTextDown
		{
			get => GetProperty(ref _fluffTextDown);
			set => SetProperty(ref _fluffTextDown, value);
		}

		[Ordinal(10)] 
		[RED("fluffTextLeft")] 
		public inkTextWidgetReference FluffTextLeft
		{
			get => GetProperty(ref _fluffTextLeft);
			set => SetProperty(ref _fluffTextLeft, value);
		}

		[Ordinal(11)] 
		[RED("headers")] 
		public CArray<CHandle<CharacterCreationTopBarHeader>> Headers
		{
			get => GetProperty(ref _headers);
			set => SetProperty(ref _headers, value);
		}

		[Ordinal(12)] 
		[RED("selectedHeader")] 
		public CHandle<CharacterCreationTopBarHeader> SelectedHeader
		{
			get => GetProperty(ref _selectedHeader);
			set => SetProperty(ref _selectedHeader, value);
		}

		[Ordinal(13)] 
		[RED("c_fluffMaxX")] 
		public CFloat C_fluffMaxX
		{
			get => GetProperty(ref _c_fluffMaxX);
			set => SetProperty(ref _c_fluffMaxX, value);
		}

		[Ordinal(14)] 
		[RED("c_fluffMinY")] 
		public CFloat C_fluffMinY
		{
			get => GetProperty(ref _c_fluffMinY);
			set => SetProperty(ref _c_fluffMinY, value);
		}

		[Ordinal(15)] 
		[RED("c_fluffMaxY")] 
		public CFloat C_fluffMaxY
		{
			get => GetProperty(ref _c_fluffMaxY);
			set => SetProperty(ref _c_fluffMaxY, value);
		}

		public CharacterCreationPersistantElements(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
