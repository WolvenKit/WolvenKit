using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CellData : CVariable
	{
		private Vector2 _position;
		private ElementData _element;
		private SpecialProperties _properties;
		private wCHandle<NetworkMinigameGridCellController> _assignedCell;
		private CBool _consumed;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector2 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("element")] 
		public ElementData Element
		{
			get => GetProperty(ref _element);
			set => SetProperty(ref _element, value);
		}

		[Ordinal(2)] 
		[RED("properties")] 
		public SpecialProperties Properties
		{
			get => GetProperty(ref _properties);
			set => SetProperty(ref _properties, value);
		}

		[Ordinal(3)] 
		[RED("assignedCell")] 
		public wCHandle<NetworkMinigameGridCellController> AssignedCell
		{
			get => GetProperty(ref _assignedCell);
			set => SetProperty(ref _assignedCell, value);
		}

		[Ordinal(4)] 
		[RED("consumed")] 
		public CBool Consumed
		{
			get => GetProperty(ref _consumed);
			set => SetProperty(ref _consumed, value);
		}

		public CellData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
